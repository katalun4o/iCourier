namespace LightSwitchApplication.PrintTemplates.Delatolas
{
    partial class DelatolasPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelatolasPrint));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblReceiverCity = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblReceiverPhone = new DevExpress.XtraReports.UI.XRLabel();
            this.lblReceiverPostCode = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPayWayBillOfExchange = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPayWayCash = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPayWayCheck = new DevExpress.XtraReports.UI.XRLabel();
            this.tickHasPayment = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tickHasPaymentCash = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tickHasPaymentBillOfExchange = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tickHasPaymentCheck = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.VoucherIDs = new DevExpress.XtraReports.Parameters.Parameter();
            this.SenderID = new DevExpress.XtraReports.Parameters.Parameter();
            this.newDataset1 = new LightSwitchApplication.NewDataset();
            this.vouchersViewDoubleAdapter = new LightSwitchApplication.NewDatasetTableAdapters.VouchersViewDoubleAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.newDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageBreak1,
            this.xrLabel39,
            this.xrLabel21,
            this.lblReceiverCity,
            this.xrLabel41,
            this.xrLabel40,
            this.lblReceiverPhone,
            this.lblReceiverPostCode,
            this.xrLabel36,
            this.xrLabel35,
            this.xrLabel34,
            this.xrBarCode1,
            this.xrLabel15,
            this.xrLabel6,
            this.xrLabel16,
            this.xrLabel7,
            this.xrLabel12,
            this.xrLabel8,
            this.lblPayWayBillOfExchange,
            this.lblPayWayCash,
            this.lblPayWayCheck,
            this.tickHasPayment,
            this.tickHasPaymentCash,
            this.tickHasPaymentBillOfExchange,
            this.tickHasPaymentCheck,
            this.xrLabel1});
            this.Detail.HeightF = 379.4167F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageBreak1
            // 
            this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 377.4167F);
            this.xrPageBreak1.Name = "xrPageBreak1";
            this.xrPageBreak1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPageBreak1_BeforePrint);
            // 
            // xrLabel39
            // 
            this.xrLabel39.CanGrow = false;
            this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "c_Date", "{0:dd/MM/yyyy}")});
            this.xrLabel39.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(19.20823F, 335.9589F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(76.83173F, 19.79172F);
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.Text = "xrLabel39";
            this.xrLabel39.WordWrap = false;
            // 
            // xrLabel21
            // 
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Memo")});
            this.xrLabel21.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(552.8766F, 313.9589F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(259.1234F, 55.45782F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.Text = "xrLabel21";
            // 
            // lblReceiverCity
            // 
            this.lblReceiverCity.CanGrow = false;
            this.lblReceiverCity.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PayerType")});
            this.lblReceiverCity.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblReceiverCity.LocationFloat = new DevExpress.Utils.PointFloat(277.5285F, 115.1606F);
            this.lblReceiverCity.Name = "lblReceiverCity";
            this.lblReceiverCity.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReceiverCity.SizeF = new System.Drawing.SizeF(57.93F, 22.92F);
            this.lblReceiverCity.StylePriority.UseFont = false;
            this.lblReceiverCity.StylePriority.UseTextAlignment = false;
            this.lblReceiverCity.Text = "lblReceiverCity";
            this.lblReceiverCity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblReceiverCity.WordWrap = false;
            // 
            // xrLabel41
            // 
            this.xrLabel41.CanGrow = false;
            this.xrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Count", "{0:#,#}")});
            this.xrLabel41.Font = new System.Drawing.Font("Verdana", 9F);
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(340.4595F, 115.1606F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(36.71F, 22.92F);
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.Text = "xrLabel41";
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel41.WordWrap = false;
            // 
            // xrLabel40
            // 
            this.xrLabel40.CanGrow = false;
            this.xrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Weight", "{0:0.00}")});
            this.xrLabel40.Font = new System.Drawing.Font("Verdana", 9F);
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(390.8745F, 115.1606F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(40.25F, 22.92F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "xrLabel40";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel40.WordWrap = false;
            // 
            // lblReceiverPhone
            // 
            this.lblReceiverPhone.CanGrow = false;
            this.lblReceiverPhone.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReceiverPhone")});
            this.lblReceiverPhone.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblReceiverPhone.LocationFloat = new DevExpress.Utils.PointFloat(336.4595F, 254.2087F);
            this.lblReceiverPhone.Name = "lblReceiverPhone";
            this.lblReceiverPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReceiverPhone.SizeF = new System.Drawing.SizeF(206.2037F, 18.00005F);
            this.lblReceiverPhone.StylePriority.UseFont = false;
            this.lblReceiverPhone.Text = "lblReceiverPhone";
            this.lblReceiverPhone.WordWrap = false;
            // 
            // lblReceiverPostCode
            // 
            this.lblReceiverPostCode.CanGrow = false;
            this.lblReceiverPostCode.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReceiverPK")});
            this.lblReceiverPostCode.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblReceiverPostCode.LocationFloat = new DevExpress.Utils.PointFloat(474.9996F, 221.3337F);
            this.lblReceiverPostCode.Name = "lblReceiverPostCode";
            this.lblReceiverPostCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReceiverPostCode.SizeF = new System.Drawing.SizeF(67.66357F, 17.58331F);
            this.lblReceiverPostCode.StylePriority.UseFont = false;
            this.lblReceiverPostCode.Text = "lblReceiverPostCode";
            this.lblReceiverPostCode.WordWrap = false;
            // 
            // xrLabel36
            // 
            this.xrLabel36.CanGrow = false;
            this.xrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReceiverAddress")});
            this.xrLabel36.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(336.4595F, 188.6254F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(206.2038F, 17.99998F);
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.Text = "xrLabel36";
            this.xrLabel36.WordWrap = false;
            // 
            // xrLabel35
            // 
            this.xrLabel35.CanGrow = false;
            this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReceiverName")});
            this.xrLabel35.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(336.4595F, 153.8724F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(206.2037F, 19.79135F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.Text = "xrLabel35";
            this.xrLabel35.WordWrap = false;
            // 
            // xrLabel34
            // 
            this.xrLabel34.CanGrow = false;
            this.xrLabel34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Name")});
            this.xrLabel34.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(71.70825F, 153.8724F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(196.8717F, 17.79134F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.Text = "xrLabel34";
            this.xrLabel34.WordWrap = false;
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Number")});
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(432.4162F, 8.000024F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(318.0804F, 80.62501F);
            this.xrBarCode1.Symbology = code128Generator1;
            // 
            // xrLabel15
            // 
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Number")});
            this.xrLabel15.Font = new System.Drawing.Font("Verdana", 9F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(133.2916F, 115.1606F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(132.2884F, 22.91995F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel15.WordWrap = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Area")});
            this.xrLabel6.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(71.70825F, 221.3337F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(72.99832F, 17.58331F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "xrLabel6";
            this.xrLabel6.WordWrap = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.CanGrow = false;
            this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PK")});
            this.xrLabel16.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(195.83F, 221.3337F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(72.74995F, 17.58331F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.Text = "xrLabel16";
            this.xrLabel16.WordWrap = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Address")});
            this.xrLabel7.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(71.70824F, 188.6254F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(196.8717F, 17.99997F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "xrLabel7";
            this.xrLabel7.WordWrap = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReceiverArea")});
            this.xrLabel12.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(336.4595F, 221.3337F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(80.95663F, 17.58328F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "xrLabel12";
            this.xrLabel12.WordWrap = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Phone")});
            this.xrLabel8.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(71.70825F, 254.3754F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(196.8717F, 17.83337F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.WordWrap = false;
            // 
            // lblPayWayBillOfExchange
            // 
            this.lblPayWayBillOfExchange.CanGrow = false;
            this.lblPayWayBillOfExchange.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPayWayBillOfExchange.LocationFloat = new DevExpress.Utils.PointFloat(627.2914F, 160.8721F);
            this.lblPayWayBillOfExchange.Name = "lblPayWayBillOfExchange";
            this.lblPayWayBillOfExchange.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPayWayBillOfExchange.SizeF = new System.Drawing.SizeF(49.91669F, 16.7916F);
            this.lblPayWayBillOfExchange.StylePriority.UseFont = false;
            this.lblPayWayBillOfExchange.Text = "lblPayWayCash";
            // 
            // lblPayWayCash
            // 
            this.lblPayWayCash.CanGrow = false;
            this.lblPayWayCash.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPayWayCash.LocationFloat = new DevExpress.Utils.PointFloat(627.2914F, 140.0805F);
            this.lblPayWayCash.Name = "lblPayWayCash";
            this.lblPayWayCash.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPayWayCash.SizeF = new System.Drawing.SizeF(49.92F, 16.79F);
            this.lblPayWayCash.StylePriority.UseFont = false;
            this.lblPayWayCash.Text = "lblPayWayCash";
            this.lblPayWayCash.WordWrap = false;
            // 
            // lblPayWayCheck
            // 
            this.lblPayWayCheck.CanGrow = false;
            this.lblPayWayCheck.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPayWayCheck.LocationFloat = new DevExpress.Utils.PointFloat(627.2914F, 183.6637F);
            this.lblPayWayCheck.Name = "lblPayWayCheck";
            this.lblPayWayCheck.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPayWayCheck.SizeF = new System.Drawing.SizeF(49.92F, 16.79F);
            this.lblPayWayCheck.StylePriority.UseFont = false;
            this.lblPayWayCheck.Text = "PayWayCheck";
            this.lblPayWayCheck.WordWrap = false;
            // 
            // tickHasPayment
            // 
            this.tickHasPayment.Image = ((System.Drawing.Image)(resources.GetObject("tickHasPayment.Image")));
            this.tickHasPayment.LocationFloat = new DevExpress.Utils.PointFloat(617.5417F, 116.1606F);
            this.tickHasPayment.Name = "tickHasPayment";
            this.tickHasPayment.SizeF = new System.Drawing.SizeF(15F, 15F);
            this.tickHasPayment.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.tickHasPayment.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.tickHasPayment_BeforePrint);
            // 
            // tickHasPaymentCash
            // 
            this.tickHasPaymentCash.Image = ((System.Drawing.Image)(resources.GetObject("tickHasPaymentCash.Image")));
            this.tickHasPaymentCash.LocationFloat = new DevExpress.Utils.PointFloat(605F, 139.0805F);
            this.tickHasPaymentCash.Name = "tickHasPaymentCash";
            this.tickHasPaymentCash.SizeF = new System.Drawing.SizeF(15F, 15F);
            this.tickHasPaymentCash.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.tickHasPaymentCash.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.tickHasPaymentCash_BeforePrint);
            // 
            // tickHasPaymentBillOfExchange
            // 
            this.tickHasPaymentBillOfExchange.Image = ((System.Drawing.Image)(resources.GetObject("tickHasPaymentBillOfExchange.Image")));
            this.tickHasPaymentBillOfExchange.LocationFloat = new DevExpress.Utils.PointFloat(605F, 159.6637F);
            this.tickHasPaymentBillOfExchange.Name = "tickHasPaymentBillOfExchange";
            this.tickHasPaymentBillOfExchange.SizeF = new System.Drawing.SizeF(15F, 15F);
            this.tickHasPaymentBillOfExchange.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.tickHasPaymentBillOfExchange.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.tickHasPaymentBillOfExchange_BeforePrint);
            // 
            // tickHasPaymentCheck
            // 
            this.tickHasPaymentCheck.Image = ((System.Drawing.Image)(resources.GetObject("tickHasPaymentCheck.Image")));
            this.tickHasPaymentCheck.LocationFloat = new DevExpress.Utils.PointFloat(605F, 182.8354F);
            this.tickHasPaymentCheck.Name = "tickHasPaymentCheck";
            this.tickHasPaymentCheck.SizeF = new System.Drawing.SizeF(15F, 15F);
            this.tickHasPaymentCheck.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.tickHasPaymentCheck.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.tickHasPaymentCheck_BeforePrint);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6.99999F, 115.1606F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(122.2916F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "ΑΣΠΡΟΠΥΡΓΟΣ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // VoucherIDs
            // 
            this.VoucherIDs.Name = "VoucherIDs";
            this.VoucherIDs.Visible = false;
            // 
            // SenderID
            // 
            this.SenderID.Name = "SenderID";
            this.SenderID.Type = typeof(decimal);
            this.SenderID.ValueInfo = "0";
            this.SenderID.Visible = false;
            // 
            // newDataset1
            // 
            this.newDataset1.DataSetName = "NewDataset";
            this.newDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vouchersViewDoubleAdapter
            // 
            this.vouchersViewDoubleAdapter.ClearBeforeFill = true;
            // 
            // DelatolasPrint
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(0, 5, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.VoucherIDs,
            this.SenderID});
            this.RequestParameters = false;
            this.Version = "13.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.DelatolasPrint_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.newDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.Parameters.Parameter VoucherIDs;
        private DevExpress.XtraReports.Parameters.Parameter SenderID;
        private NewDataset newDataset1;
        private NewDatasetTableAdapters.VouchersViewDoubleAdapter vouchersViewDoubleAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel39;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel41;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel lblReceiverPhone;
        private DevExpress.XtraReports.UI.XRLabel lblReceiverPostCode;
        private DevExpress.XtraReports.UI.XRLabel xrLabel36;
        private DevExpress.XtraReports.UI.XRLabel xrLabel35;
        private DevExpress.XtraReports.UI.XRLabel xrLabel34;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRPageBreak xrPageBreak1;
        private DevExpress.XtraReports.UI.XRLabel lblPayWayBillOfExchange;
        private DevExpress.XtraReports.UI.XRLabel lblPayWayCash;
        private DevExpress.XtraReports.UI.XRLabel lblPayWayCheck;
        private DevExpress.XtraReports.UI.XRPictureBox tickHasPayment;
        private DevExpress.XtraReports.UI.XRPictureBox tickHasPaymentCash;
        private DevExpress.XtraReports.UI.XRPictureBox tickHasPaymentBillOfExchange;
        private DevExpress.XtraReports.UI.XRPictureBox tickHasPaymentCheck;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lblReceiverCity;
    }
}
