// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Platform {
    
    
    internal partial class UpdateDialog {
        
        private Gtk.Alignment alignment1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label label1;
        
        private Gtk.Frame frame2;
        
        private Gtk.Alignment GtkAlignment1;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.VBox productBox;
        
        private Gtk.CheckButton checkAutomaticallyCheck;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Platform.UpdateDialog
            this.Name = "MonoDevelop.Platform.UpdateDialog";
            this.Title = Mono.Unix.Catalog.GetString("Updates Available");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Internal child MonoDevelop.Platform.UpdateDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            // Container child alignment1.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(6));
            // Container child vbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Updates are available for the following packages. Please close\nMonoDevelop before installing them.");
            this.vbox2.Add(this.label1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.label1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.frame2 = new Gtk.Frame();
            this.frame2.Name = "frame2";
            this.frame2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child frame2.Gtk.Container+ContainerChild
            this.GtkAlignment1 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment1.Name = "GtkAlignment1";
            // Container child GtkAlignment1.Gtk.Container+ContainerChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            Gtk.Viewport w3 = new Gtk.Viewport();
            w3.ShadowType = ((Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.productBox = new Gtk.VBox();
            this.productBox.Name = "productBox";
            this.productBox.Spacing = 12;
            w3.Add(this.productBox);
            this.scrolledwindow1.Add(w3);
            this.GtkAlignment1.Add(this.scrolledwindow1);
            this.frame2.Add(this.GtkAlignment1);
            this.vbox2.Add(this.frame2);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox2[this.frame2]));
            w8.Position = 1;
            // Container child vbox2.Gtk.Box+BoxChild
            this.checkAutomaticallyCheck = new Gtk.CheckButton();
            this.checkAutomaticallyCheck.CanFocus = true;
            this.checkAutomaticallyCheck.Name = "checkAutomaticallyCheck";
            this.checkAutomaticallyCheck.Label = Mono.Unix.Catalog.GetString("Check for updates automatically");
            this.checkAutomaticallyCheck.DrawIndicator = true;
            this.checkAutomaticallyCheck.UseUnderline = true;
            this.vbox2.Add(this.checkAutomaticallyCheck);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.checkAutomaticallyCheck]));
            w9.Position = 2;
            w9.Expand = false;
            w9.Fill = false;
            this.alignment1.Add(this.vbox2);
            w1.Add(this.alignment1);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(w1[this.alignment1]));
            w11.Position = 0;
            // Internal child MonoDevelop.Platform.UpdateDialog.ActionArea
            Gtk.HButtonBox w12 = this.ActionArea;
            w12.Name = "dialog1_ActionArea";
            w12.Spacing = 10;
            w12.BorderWidth = ((uint)(5));
            w12.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-close";
            this.AddActionWidget(this.buttonOk, -7);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(w12[this.buttonOk]));
            w13.Expand = false;
            w13.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 608;
            this.DefaultHeight = 392;
            this.Show();
        }
    }
}
