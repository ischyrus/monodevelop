// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.ChangeLogAddIn {
    
    
    internal partial class AddLogEntryDialog {
        
        private Gtk.VBox vbox1;
        
        private Gtk.VPaned vpaned1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label label1;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView fileList;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Label label3;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TextView textview;
        
        private Gtk.HBox boxNewFile;
        
        private Gtk.Image image36;
        
        private Gtk.Label label7;
        
        private Gtk.HBox boxNoFile;
        
        private Gtk.Image image37;
        
        private Gtk.Label label8;
        
        private Gtk.HBox hbox3;
        
        private Gtk.VBox vbox4;
        
        private Gtk.Image image38;
        
        private Gtk.Label label9;
        
        private Gtk.Button button7;
        
        private Gtk.Button button119;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.ChangeLogAddIn.AddLogEntryDialog
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "MonoDevelop.ChangeLogAddIn.AddLogEntryDialog";
            this.Title = Mono.Unix.Catalog.GetString("ChangeLog");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Internal child MonoDevelop.ChangeLogAddIn.AddLogEntryDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog_VBox.Gtk.Box+BoxChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            this.vbox1.BorderWidth = ((uint)(6));
            // Container child vbox1.Gtk.Box+BoxChild
            this.vpaned1 = new Gtk.VPaned();
            this.vpaned1.CanFocus = true;
            this.vpaned1.Name = "vpaned1";
            this.vpaned1.Position = 116;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Modified ChangeLog files:");
            this.vbox2.Add(this.label1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.label1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.fileList = new Gtk.TreeView();
            this.fileList.CanFocus = true;
            this.fileList.Name = "fileList";
            this.fileList.HeadersVisible = false;
            this.fileList.HeadersClickable = true;
            this.scrolledwindow2.Add(this.fileList);
            this.vbox2.Add(this.scrolledwindow2);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow2]));
            w4.Position = 1;
            this.vpaned1.Add(this.vbox2);
            Gtk.Paned.PanedChild w5 = ((Gtk.Paned.PanedChild)(this.vpaned1[this.vbox2]));
            w5.Resize = false;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("ChangeLog entry:");
            this.vbox3.Add(this.label3);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox3[this.label3]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.textview = new Gtk.TextView();
            this.textview.CanFocus = true;
            this.textview.Name = "textview";
            this.scrolledwindow1.Add(this.textview);
            this.vbox3.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox3[this.scrolledwindow1]));
            w8.Position = 1;
            this.vpaned1.Add(this.vbox3);
            this.vbox1.Add(this.vpaned1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox1[this.vpaned1]));
            w10.Position = 0;
            // Container child vbox1.Gtk.Box+BoxChild
            this.boxNewFile = new Gtk.HBox();
            this.boxNewFile.Name = "boxNewFile";
            this.boxNewFile.Spacing = 6;
            // Container child boxNewFile.Gtk.Box+BoxChild
            this.image36 = new Gtk.Image();
            this.image36.Name = "image36";
            this.image36.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-new", Gtk.IconSize.SmallToolbar, 18);
            this.boxNewFile.Add(this.image36);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.boxNewFile[this.image36]));
            w11.Position = 0;
            w11.Expand = false;
            w11.Fill = false;
            // Container child boxNewFile.Gtk.Box+BoxChild
            this.label7 = new Gtk.Label();
            this.label7.WidthRequest = 500;
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("This ChangeLog file does not exist and will be created.");
            this.label7.Wrap = true;
            this.boxNewFile.Add(this.label7);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.boxNewFile[this.label7]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            this.vbox1.Add(this.boxNewFile);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox1[this.boxNewFile]));
            w13.Position = 1;
            w13.Expand = false;
            w13.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.boxNoFile = new Gtk.HBox();
            this.boxNoFile.Name = "boxNoFile";
            this.boxNoFile.Spacing = 6;
            // Container child boxNoFile.Gtk.Box+BoxChild
            this.image37 = new Gtk.Image();
            this.image37.Name = "image37";
            this.image37.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-warning", Gtk.IconSize.SmallToolbar, 18);
            this.boxNoFile.Add(this.image37);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.boxNoFile[this.image37]));
            w14.Position = 0;
            w14.Expand = false;
            w14.Fill = false;
            // Container child boxNoFile.Gtk.Box+BoxChild
            this.label8 = new Gtk.Label();
            this.label8.WidthRequest = 500;
            this.label8.Name = "label8";
            this.label8.Xalign = 0F;
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("This ChangeLog file does not exist and will <b>not</b> be created.");
            this.label8.UseMarkup = true;
            this.label8.Wrap = true;
            this.boxNoFile.Add(this.label8);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.boxNoFile[this.label8]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            this.vbox1.Add(this.boxNoFile);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox1[this.boxNoFile]));
            w16.Position = 2;
            w16.Expand = false;
            w16.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.image38 = new Gtk.Image();
            this.image38.Name = "image38";
            this.image38.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-info", Gtk.IconSize.SmallToolbar, 18);
            this.vbox4.Add(this.image38);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox4[this.image38]));
            w17.Position = 0;
            w17.Expand = false;
            w17.Fill = false;
            this.hbox3.Add(this.vbox4);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox3[this.vbox4]));
            w18.Position = 0;
            w18.Expand = false;
            w18.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.label9 = new Gtk.Label();
            this.label9.WidthRequest = 500;
            this.label9.Name = "label9";
            this.label9.Xalign = 0F;
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("To change the ChangeLog creation and update policies, open the options dialog of the project or solution and click on the 'ChangeLog Integration\" section.");
            this.label9.UseMarkup = true;
            this.label9.Wrap = true;
            this.hbox3.Add(this.label9);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.hbox3[this.label9]));
            w19.Position = 1;
            w19.Expand = false;
            w19.Fill = false;
            this.vbox1.Add(this.hbox3);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
            w20.Position = 3;
            w20.Expand = false;
            w20.Fill = false;
            w1.Add(this.vbox1);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(w1[this.vbox1]));
            w21.Position = 0;
            // Internal child MonoDevelop.ChangeLogAddIn.AddLogEntryDialog.ActionArea
            Gtk.HButtonBox w22 = this.ActionArea;
            w22.Events = ((Gdk.EventMask)(256));
            w22.Name = "ChangeLogAddIn.AddLogEntryDialog_ActionArea";
            w22.Spacing = 10;
            w22.BorderWidth = ((uint)(5));
            w22.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child ChangeLogAddIn.AddLogEntryDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button7 = new Gtk.Button();
            this.button7.CanDefault = true;
            this.button7.CanFocus = true;
            this.button7.Name = "button7";
            this.button7.UseStock = true;
            this.button7.UseUnderline = true;
            this.button7.Label = "gtk-cancel";
            this.AddActionWidget(this.button7, -6);
            Gtk.ButtonBox.ButtonBoxChild w23 = ((Gtk.ButtonBox.ButtonBoxChild)(w22[this.button7]));
            w23.Expand = false;
            w23.Fill = false;
            // Container child ChangeLogAddIn.AddLogEntryDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button119 = new Gtk.Button();
            this.button119.CanDefault = true;
            this.button119.CanFocus = true;
            this.button119.Name = "button119";
            this.button119.UseStock = true;
            this.button119.UseUnderline = true;
            this.button119.Label = "gtk-ok";
            this.AddActionWidget(this.button119, -5);
            Gtk.ButtonBox.ButtonBoxChild w24 = ((Gtk.ButtonBox.ButtonBoxChild)(w22[this.button119]));
            w24.Position = 1;
            w24.Expand = false;
            w24.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 573;
            this.DefaultHeight = 510;
            this.boxNewFile.Hide();
            this.boxNoFile.Hide();
            this.Show();
        }
    }
}
