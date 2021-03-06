//
// NestingRule.cs
//
// Author:
//       Rodrigo Moya <rodrigo.moya@xamarin.com>
//
// Copyright (c) 2019, Microsoft Inc. (http://microsoft.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MonoDevelop.Core;

namespace MonoDevelop.Projects.FileNesting
{
	internal enum NestingRuleKind
	{
		ExtensionToExtension,
		FileSuffixToExtension,
		AddedExtension,
		PathSegment,
		AllExtensions,
		FileToFile
	}

	internal class NestingRule
	{
		public const string AllFilesWildcard = ".*";

		List<string> patterns;

		public NestingRule (NestingRuleKind kind, string appliesTo, IEnumerable<string> patterns)
		{
			Kind = kind;
			AppliesTo = appliesTo ?? AllFilesWildcard;
			this.patterns = patterns?.ToList () ?? new List<string> ();
		}

		public NestingRuleKind Kind { get; private set; }

		public string AppliesTo { get; private set; }

		bool CheckParentForFile (Project project, FilePath inputFile, FilePath parentFile)
		{
			if (project.Files.Any (x => x.FilePath == parentFile) && inputFile != parentFile && !parentFile.IsDirectory && inputFile.ParentDirectory == parentFile.ParentDirectory) {
				LoggingService.LogInfo ($"Applied rule for nesting {inputFile} under {parentFile}");
				return true;
			}

			return false;
		}

		public FilePath GetParentFile (Project project, FilePath inputFile)
		{
			string parentFile, inputExtension;

			inputExtension = Path.GetExtension (inputFile);

			switch (Kind) {
			case NestingRuleKind.AddedExtension:
				// This is the simplest rules, and applies to all files, if we find a file
				// with the same name minus the extension, that's the parent.
				parentFile = inputFile.ParentDirectory.Combine (inputFile.FileNameWithoutExtension);
				if (CheckParentForFile (project, inputFile, parentFile))
					return parentFile;
				break;

			case NestingRuleKind.AllExtensions:
				if (AppliesTo == AllFilesWildcard || AppliesTo == inputExtension) {
					foreach (var pt in patterns) {
						parentFile = inputFile.ParentDirectory.Combine ($"{Path.GetFileNameWithoutExtension (inputFile)}{pt}");
						if (CheckParentForFile (project, inputFile, parentFile))
							return parentFile;
					}
				}
				break;

			case NestingRuleKind.ExtensionToExtension:
				if (inputExtension == AppliesTo) {
					foreach (var pt in patterns) {
						parentFile = inputFile.ParentDirectory.Combine ($"{Path.GetFileNameWithoutExtension (inputFile)}{pt}");
						if (CheckParentForFile (project, inputFile, parentFile))
							return parentFile;
					}
				}
				break;

			case NestingRuleKind.FileSuffixToExtension:
				string inputFileString = inputFile;
				if (inputFileString.EndsWith (AppliesTo, StringComparison.OrdinalIgnoreCase)) {
					int suffixPosition = inputFileString.Length - AppliesTo.Length;
					foreach (var pt in patterns) {
						parentFile = inputFileString.Remove (suffixPosition, AppliesTo.Length).Insert (suffixPosition, pt);
						if (CheckParentForFile (project, inputFile, parentFile)) {
							return parentFile;
						}
					}
				}
				break;

			case NestingRuleKind.FileToFile:
				if (AppliesTo == Path.GetFileName (inputFile)) {
					foreach (var pt in patterns) {
						parentFile = inputFile.ParentDirectory.Combine (pt);
						if (CheckParentForFile (project, inputFile, parentFile)) {
							return parentFile;
						}
					}
				}
				break;

			case NestingRuleKind.PathSegment:
				if (AppliesTo == AllFilesWildcard || AppliesTo == inputExtension) {
					foreach (var pt in patterns) {
						// Search for $filename.$extension for $filename.$path_segment.$extension
						parentFile = inputFile.ParentDirectory.Combine ($"{Path.GetFileNameWithoutExtension (Path.GetFileNameWithoutExtension (inputFile))}{inputExtension}");
						if (CheckParentForFile (project, inputFile, parentFile)) {
							return parentFile;
						}
					}
				}
				break;

			}

			return null;
		}
	}
}
