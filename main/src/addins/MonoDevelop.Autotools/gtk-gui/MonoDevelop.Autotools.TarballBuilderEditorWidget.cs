// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Autotools {
    
    
    public partial class TarballBuilderEditorWidget {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label2;
        
        private MonoDevelop.Components.FolderEntry folderEntry;
        
        private Gtk.RadioButton radioUseExisting;
        
        private Gtk.RadioButton radioGenerate;
        
        private Gtk.VBox boxGenerate;
        
        private Gtk.HBox boxConfig;
        
        private Gtk.Label label4;
        
        private Gtk.Label label3;
        
        private Gtk.ComboBox comboConfigs;
        
        private Gtk.HBox boxConfig1;
        
        private Gtk.Label label5;
        
        private Gtk.Label label6;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Label label8;
        
        private Gtk.RadioButton rbAutotools;
        
        private Gtk.Label label9;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label label1;
        
        private Gtk.RadioButton rbSimple;
        
        private Gtk.Label label7;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Autotools.TarballBuilderEditorWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Autotools.TarballBuilderEditorWidget";
            // Container child MonoDevelop.Autotools.TarballBuilderEditorWidget.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Deploy directory:");
            this.hbox1.Add(this.label2);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox1[this.label2]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.folderEntry = new MonoDevelop.Components.FolderEntry();
            this.folderEntry.Name = "folderEntry";
            this.folderEntry.BrowserTitle = "Target Directory";
            this.hbox1.Add(this.folderEntry);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.folderEntry]));
            w2.Position = 1;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.radioUseExisting = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Use existing Makefiles"));
            this.radioUseExisting.CanFocus = true;
            this.radioUseExisting.Name = "radioUseExisting";
            this.radioUseExisting.Active = true;
            this.radioUseExisting.DrawIndicator = true;
            this.radioUseExisting.UseUnderline = true;
            this.radioUseExisting.Group = new GLib.SList(System.IntPtr.Zero);
            this.vbox2.Add(this.radioUseExisting);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.radioUseExisting]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.radioGenerate = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Generate new Makefiles"));
            this.radioGenerate.CanFocus = true;
            this.radioGenerate.Name = "radioGenerate";
            this.radioGenerate.DrawIndicator = true;
            this.radioGenerate.UseUnderline = true;
            this.radioGenerate.Group = this.radioUseExisting.Group;
            this.vbox2.Add(this.radioGenerate);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox2[this.radioGenerate]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.boxGenerate = new Gtk.VBox();
            this.boxGenerate.Name = "boxGenerate";
            this.boxGenerate.Spacing = 6;
            // Container child boxGenerate.Gtk.Box+BoxChild
            this.boxConfig = new Gtk.HBox();
            this.boxConfig.Name = "boxConfig";
            this.boxConfig.Spacing = 6;
            // Container child boxConfig.Gtk.Box+BoxChild
            this.label4 = new Gtk.Label();
            this.label4.WidthRequest = 24;
            this.label4.Name = "label4";
            this.label4.LabelProp = "";
            this.boxConfig.Add(this.label4);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.boxConfig[this.label4]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child boxConfig.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Default configuration:");
            this.boxConfig.Add(this.label3);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.boxConfig[this.label3]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child boxConfig.Gtk.Box+BoxChild
            this.comboConfigs = Gtk.ComboBox.NewText();
            this.comboConfigs.Name = "comboConfigs";
            this.boxConfig.Add(this.comboConfigs);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.boxConfig[this.comboConfigs]));
            w8.Position = 2;
            this.boxGenerate.Add(this.boxConfig);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.boxGenerate[this.boxConfig]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Container child boxGenerate.Gtk.Box+BoxChild
            this.boxConfig1 = new Gtk.HBox();
            this.boxConfig1.Name = "boxConfig1";
            this.boxConfig1.Spacing = 6;
            // Container child boxConfig1.Gtk.Box+BoxChild
            this.label5 = new Gtk.Label();
            this.label5.WidthRequest = 24;
            this.label5.Name = "label5";
            this.label5.LabelProp = "";
            this.boxConfig1.Add(this.label5);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.boxConfig1[this.label5]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child boxConfig1.Gtk.Box+BoxChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("Select the kind of Makefile to generate:");
            this.boxConfig1.Add(this.label6);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.boxConfig1[this.label6]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            this.boxGenerate.Add(this.boxConfig1);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.boxGenerate[this.boxConfig1]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            // Container child boxGenerate.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.label8 = new Gtk.Label();
            this.label8.WidthRequest = 24;
            this.label8.Name = "label8";
            this.label8.LabelProp = "";
            this.hbox3.Add(this.label8);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox3[this.label8]));
            w13.Position = 0;
            w13.Expand = false;
            w13.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.rbAutotools = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Autotools based"));
            this.rbAutotools.CanFocus = true;
            this.rbAutotools.Name = "rbAutotools";
            this.rbAutotools.Active = true;
            this.rbAutotools.DrawIndicator = true;
            this.rbAutotools.UseUnderline = true;
            this.rbAutotools.Group = new GLib.SList(System.IntPtr.Zero);
            this.rbAutotools.Remove(this.rbAutotools.Child);
            // Container child rbAutotools.Gtk.Container+ContainerChild
            this.label9 = new Gtk.Label();
            this.label9.WidthRequest = 550;
            this.label9.Name = "label9";
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("<b>Autotools based Makefile</b>\nGenerates a Makefile structure based on Autotools, with the standard targets and configuration scripts.");
            this.label9.UseMarkup = true;
            this.label9.Wrap = true;
            this.rbAutotools.Add(this.label9);
            this.hbox3.Add(this.rbAutotools);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox3[this.rbAutotools]));
            w15.Position = 1;
            this.boxGenerate.Add(this.hbox3);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.boxGenerate[this.hbox3]));
            w16.Position = 2;
            w16.Expand = false;
            w16.Fill = false;
            // Container child boxGenerate.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.WidthRequest = 24;
            this.label1.Name = "label1";
            this.label1.LabelProp = "";
            this.hbox2.Add(this.label1);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.hbox2[this.label1]));
            w17.Position = 0;
            w17.Expand = false;
            w17.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.rbSimple = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Simple"));
            this.rbSimple.CanFocus = true;
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.DrawIndicator = true;
            this.rbSimple.UseUnderline = true;
            this.rbSimple.Group = this.rbAutotools.Group;
            this.rbSimple.Remove(this.rbSimple.Child);
            // Container child rbSimple.Gtk.Container+ContainerChild
            this.label7 = new Gtk.Label();
            this.label7.WidthRequest = 550;
            this.label7.Name = "label7";
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("<b>Simple Makefile</b>\nGenerates set of Makefiles with the most common targets, and a configuration script that does a basic check of package dependencies.");
            this.label7.UseMarkup = true;
            this.label7.Wrap = true;
            this.rbSimple.Add(this.label7);
            this.hbox2.Add(this.rbSimple);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.hbox2[this.rbSimple]));
            w19.Position = 1;
            this.boxGenerate.Add(this.hbox2);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.boxGenerate[this.hbox2]));
            w20.Position = 3;
            w20.Expand = false;
            w20.Fill = false;
            this.vbox2.Add(this.boxGenerate);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.vbox2[this.boxGenerate]));
            w21.Position = 3;
            w21.Expand = false;
            w21.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.folderEntry.PathChanged += new System.EventHandler(this.OnFolderEntryPathChanged);
            this.radioUseExisting.Clicked += new System.EventHandler(this.OnRadioUseExistingClicked);
            this.radioGenerate.Clicked += new System.EventHandler(this.OnRadioGenerateClicked);
            this.comboConfigs.Changed += new System.EventHandler(this.OnComboConfigsChanged);
            this.rbAutotools.Toggled += new System.EventHandler(this.OnRbAutotoolsToggled);
            this.rbSimple.Toggled += new System.EventHandler(this.OnRbSimpleToggled);
        }
    }
}
