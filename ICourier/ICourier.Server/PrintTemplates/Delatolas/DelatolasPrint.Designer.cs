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
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
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
            this.xrLabel20,
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
            this.xrPictureBox1});
            this.Detail.HeightF = 354.0833F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageBreak1
            // 
            this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 352.0833F);
            this.xrPageBreak1.Name = "xrPageBreak1";
            this.xrPageBreak1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPageBreak1_BeforePrint);
            // 
            // xrLabel39
            // 
            this.xrLabel39.CanGrow = false;
            this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "c_Date", "{0:dd/MM/yyyy}")});
            this.xrLabel39.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(33.20823F, 295.9589F);
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
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(531.8766F, 274.4588F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(120.3314F, 41.29178F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.Text = "xrLabel21";
            this.xrLabel21.WordWrap = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.CanGrow = false;
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PayerType")});
            this.xrLabel20.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(272.5285F, 115.292F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(44.20645F, 16.78998F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.Text = "xrLabel20";
            this.xrLabel20.WordWrap = false;
            // 
            // xrLabel41
            // 
            this.xrLabel41.CanGrow = false;
            this.xrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Count", "{0:#,#}")});
            this.xrLabel41.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(336.4595F, 115.2937F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(36.70663F, 17.78999F);
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.Text = "xrLabel41";
            this.xrLabel41.WordWrap = false;
            // 
            // xrLabel40
            // 
            this.xrLabel40.CanGrow = false;
            this.xrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Weight", "{0:0.00}")});
            this.xrLabel40.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(377.1662F, 116.2903F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(40.24991F, 16.79166F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.Text = "xrLabel40";
            this.xrLabel40.WordWrap = false;
            // 
            // lblReceiverPhone
            // 
            this.lblReceiverPhone.CanGrow = false;
            this.lblReceiverPhone.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReceiverPhone")});
            this.lblReceiverPhone.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblReceiverPhone.LocationFloat = new DevExpress.Utils.PointFloat(324.3315F, 230.2087F);
            this.lblReceiverPhone.Name = "lblReceiverPhone";
            this.lblReceiverPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReceiverPhone.SizeF = new System.Drawing.SizeF(195.665F, 18.00005F);
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
            this.lblReceiverPostCode.LocationFloat = new DevExpress.Utils.PointFloat(452.3329F, 194.3771F);
            this.lblReceiverPostCode.Name = "lblReceiverPostCode";
            this.lblReceiverPostCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReceiverPostCode.SizeF = new System.Drawing.SizeF(67.66357F, 25F);
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
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(324.3315F, 170.8354F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(195.665F, 17.99998F);
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
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(324.3315F, 146.8741F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(195.665F, 19.79135F);
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
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(71.70824F, 148.8741F);
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
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(432.4162F, 16.00002F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(288.9138F, 73.33334F);
            this.xrBarCode1.Symbology = code128Generator1;
            // 
            // xrLabel15
            // 
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Number")});
            this.xrLabel15.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(132.2916F, 111.1606F);
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(35.20824F, 214.6254F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(109.2066F, 17.58331F);
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
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(195.83F, 194.3771F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(72.74995F, 25F);
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
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(71.70824F, 170.8354F);
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
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(293.0815F, 214.6254F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(112.4966F, 17.58328F);
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(71.70824F, 230.3754F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(196.8717F, 17.83339F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.WordWrap = false;
            // 
            // lblPayWayBillOfExchange
            // 
            this.lblPayWayBillOfExchange.CanGrow = false;
            this.lblPayWayBillOfExchange.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPayWayBillOfExchange.LocationFloat = new DevExpress.Utils.PointFloat(602.2914F, 150.8721F);
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
            this.lblPayWayCash.LocationFloat = new DevExpress.Utils.PointFloat(602.2914F, 134.0805F);
            this.lblPayWayCash.Name = "lblPayWayCash";
            this.lblPayWayCash.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPayWayCash.SizeF = new System.Drawing.SizeF(49.91669F, 16.7916F);
            this.lblPayWayCash.StylePriority.UseFont = false;
            this.lblPayWayCash.Text = "lblPayWayCash";
            this.lblPayWayCash.WordWrap = false;
            // 
            // lblPayWayCheck
            // 
            this.lblPayWayCheck.CanGrow = false;
            this.lblPayWayCheck.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPayWayCheck.LocationFloat = new DevExpress.Utils.PointFloat(602.2914F, 165.6637F);
            this.lblPayWayCheck.Name = "lblPayWayCheck";
            this.lblPayWayCheck.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPayWayCheck.SizeF = new System.Drawing.SizeF(49.91669F, 18.7916F);
            this.lblPayWayCheck.StylePriority.UseFont = false;
            this.lblPayWayCheck.Text = "PayWayCheck";
            this.lblPayWayCheck.WordWrap = false;
            // 
            // tickHasPayment
            // 
            this.tickHasPayment.ImageUrl = "D:\\Projects\\git\\iCourier\\ICourier\\ICourier.Server\\PrintTemplates\\Delatolas\\rsz_ti" +
    "ck.png";
            this.tickHasPayment.LocationFloat = new DevExpress.Utils.PointFloat(589.5417F, 114.1606F);
            this.tickHasPayment.Name = "tickHasPayment";
            this.tickHasPayment.SizeF = new System.Drawing.SizeF(15F, 15F);
            this.tickHasPayment.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.tickHasPayment.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.tickHasPayment_BeforePrint);
            // 
            // tickHasPaymentCash
            // 
            this.tickHasPaymentCash.ImageUrl = "D:\\Projects\\git\\iCourier\\ICourier\\ICourier.Server\\PrintTemplates\\Delatolas\\rsz_ti" +
    "ck.png";
            this.tickHasPaymentCash.LocationFloat = new DevExpress.Utils.PointFloat(578F, 132.0805F);
            this.tickHasPaymentCash.Name = "tickHasPaymentCash";
            this.tickHasPaymentCash.SizeF = new System.Drawing.SizeF(15F, 15F);
            this.tickHasPaymentCash.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.tickHasPaymentCash.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.tickHasPaymentCash_BeforePrint);
            // 
            // tickHasPaymentBillOfExchange
            // 
            this.tickHasPaymentBillOfExchange.ImageUrl = "D:\\Projects\\git\\iCourier\\ICourier\\ICourier.Server\\PrintTemplates\\Delatolas\\rsz_ti" +
    "ck.png";
            this.tickHasPaymentBillOfExchange.LocationFloat = new DevExpress.Utils.PointFloat(578F, 150.6637F);
            this.tickHasPaymentBillOfExchange.Name = "tickHasPaymentBillOfExchange";
            this.tickHasPaymentBillOfExchange.SizeF = new System.Drawing.SizeF(15F, 15F);
            this.tickHasPaymentBillOfExchange.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.tickHasPaymentBillOfExchange.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.tickHasPaymentBillOfExchange_BeforePrint);
            // 
            // tickHasPaymentCheck
            // 
            this.tickHasPaymentCheck.ImageUrl = "D:\\Projects\\git\\iCourier\\ICourier\\ICourier.Server\\PrintTemplates\\Delatolas\\rsz_ti" +
    "ck.png";
            this.tickHasPaymentCheck.LocationFloat = new DevExpress.Utils.PointFloat(578F, 170.8354F);
            this.tickHasPaymentCheck.Name = "tickHasPaymentCheck";
            this.tickHasPaymentCheck.SizeF = new System.Drawing.SizeF(15F, 15F);
            this.tickHasPaymentCheck.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.tickHasPaymentCheck.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.tickHasPaymentCheck_BeforePrint);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.999704F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(822.3333F, 334.0836F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 12.54168F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 56.4167F;
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
            this.Margins = new System.Drawing.Printing.Margins(0, 5, 13, 56);
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel41;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel lblReceiverPhone;
        private DevExpress.XtraReports.UI.XRLabel lblReceiverPostCode;
        private DevExpress.XtraReports.UI.XRLabel xrLabel36;
        private DevExpress.XtraReports.UI.XRLabel xrLabel35;
        private DevExpress.XtraReports.UI.XRLabel xrLabel34;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
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
    }
}
