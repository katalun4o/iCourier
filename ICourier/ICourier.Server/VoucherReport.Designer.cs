namespace LightSwitchApplication
{
    partial class VoucherReport
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
            this.xrSubreport3 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.VoucherIDs = new DevExpress.XtraReports.Parameters.Parameter();
            this.lightSwitchDataSource1 = new DevExpress.XtraReports.LightSwitchDataSource();
            this.voucherTemplateReport2 = new LightSwitchApplication.VoucherTemplateReport();
            this.voucherTemplateReport3 = new LightSwitchApplication.VoucherTemplateReport();
            this.SenderID = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.voucherTemplateReport2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherTemplateReport3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageBreak1,
            this.xrSubreport3,
            this.xrSubreport2,
            this.xrSubreport1});
            this.Detail.HeightF = 659.9166F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageBreak1
            // 
            this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 657.9166F);
            this.xrPageBreak1.Name = "xrPageBreak1";
            // 
            // xrSubreport3
            // 
            this.xrSubreport3.Id = 0;
            this.xrSubreport3.LocationFloat = new DevExpress.Utils.PointFloat(776F, 0F);
            this.xrSubreport3.Name = "xrSubreport3";
            this.xrSubreport3.ReportSource = new LightSwitchApplication.VoucherTemplateReport();
            this.xrSubreport3.SizeF = new System.Drawing.SizeF(365F, 657.9166F);
            this.xrSubreport3.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreport3_BeforePrint);
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.Id = 0;
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(394F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ReportSource = new LightSwitchApplication.VoucherTemplateReport();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(365F, 657.9166F);
            this.xrSubreport2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreport2_BeforePrint);
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.Id = 0;
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ReportSource = new LightSwitchApplication.VoucherTemplateReport();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(365F, 657.9166F);
            this.xrSubreport1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreport1_BeforePrint);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 21F);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Arial", 8F);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Arial", 9F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 22.45833F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 0F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // VoucherIDs
            // 
            this.VoucherIDs.Description = "Parameter1";
            this.VoucherIDs.Name = "VoucherIDs";
            this.VoucherIDs.Visible = false;
            // 
            // lightSwitchDataSource1
            // 
            this.lightSwitchDataSource1.CollectionName = "Vouchers";
            this.lightSwitchDataSource1.DataSource = typeof(LightSwitchApplication.Voucher);
            this.lightSwitchDataSource1.DataSourceName = "CourierAzureData";
            // 
            // voucherTemplateReport2
            // 
            this.voucherTemplateReport2.Margins = new System.Drawing.Printing.Margins(12, 488, 0, 0);
            this.voucherTemplateReport2.Name = "voucherTemplateReport2";
            this.voucherTemplateReport2.PageHeight = 1100;
            this.voucherTemplateReport2.PageWidth = 850;
            this.voucherTemplateReport2.RequestParameters = false;
            this.voucherTemplateReport2.Version = "13.2";
            // 
            // voucherTemplateReport3
            // 
            this.voucherTemplateReport3.Margins = new System.Drawing.Printing.Margins(12, 488, 0, 0);
            this.voucherTemplateReport3.Name = "voucherTemplateReport3";
            this.voucherTemplateReport3.PageHeight = 1100;
            this.voucherTemplateReport3.PageWidth = 850;
            this.voucherTemplateReport3.RequestParameters = false;
            this.voucherTemplateReport3.Version = "13.2";
            // 
            // SenderID
            // 
            this.SenderID.Name = "SenderID";
            this.SenderID.Type = typeof(decimal);
            this.SenderID.ValueInfo = "0";
            this.SenderID.Visible = false;
            // 
            // VoucherReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(14, 10, 22, 0);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.VoucherIDs,
            this.SenderID});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "13.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.VoucherReport_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.VoucherReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.voucherTemplateReport2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherTemplateReport3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.LightSwitchDataSource lightSwitchDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title; 
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.Parameters.Parameter VoucherIDs;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport3;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private VoucherTemplateReport voucherTemplateReport2;
        private VoucherTemplateReport voucherTemplateReport3;
        private DevExpress.XtraReports.UI.XRPageBreak xrPageBreak1;
        private DevExpress.XtraReports.Parameters.Parameter SenderID;
    }
}
