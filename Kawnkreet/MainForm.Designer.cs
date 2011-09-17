using System;

namespace Kawnkreet
{
    public partial class MainForm
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
        #region Windows Form Designer generated code       
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrlMainForm = new System.Windows.Forms.TabControl();
            this.tabDesign = new System.Windows.Forms.TabPage();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnDesign = new System.Windows.Forms.Button();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtMaterialCost = new System.Windows.Forms.TextBox();
            this.txtThermalMass = new System.Windows.Forms.TextBox();
            this.txtSlabDepth = new System.Windows.Forms.TextBox();
            this.lblThermalMass = new System.Windows.Forms.Label();
            this.lblMaterialCost = new System.Windows.Forms.Label();
            this.lblSlabDepth = new System.Windows.Forms.Label();
            this.grpMaterialPricing = new System.Windows.Forms.GroupBox();
            this.txtSteelPrice = new System.Windows.Forms.TextBox();
            this.txtConcretePrice = new System.Windows.Forms.TextBox();
            this.lblSteelPrice = new System.Windows.Forms.Label();
            this.lblConcretePrice = new System.Windows.Forms.Label();
            this.grpConcreteSpec = new System.Windows.Forms.GroupBox();
            this.cmbConcreteGrade = new System.Windows.Forms.ComboBox();
            this.txtPcCem = new System.Windows.Forms.TextBox();
            this.txtPcGGBS = new System.Windows.Forms.TextBox();
            this.txtPcAgg = new System.Windows.Forms.TextBox();
            this.txtPcWater = new System.Windows.Forms.TextBox();
            this.txtFck = new System.Windows.Forms.TextBox();
            this.txtCover = new System.Windows.Forms.TextBox();
            this.lblConcreteGrade = new System.Windows.Forms.Label();
            this.lblPcCem = new System.Windows.Forms.Label();
            this.lblPcGGBS = new System.Windows.Forms.Label();
            this.lblPcAgg = new System.Windows.Forms.Label();
            this.lblPcWater = new System.Windows.Forms.Label();
            this.lblFck = new System.Windows.Forms.Label();
            this.lblCover = new System.Windows.Forms.Label();
            this.grpTransport = new System.Windows.Forms.GroupBox();
            this.txtGGBSBatch = new System.Windows.Forms.TextBox();
            this.lblGGBSToBatch = new System.Windows.Forms.Label();
            this.txtBatchSite = new System.Windows.Forms.TextBox();
            this.lblBatchToSite = new System.Windows.Forms.Label();
            this.grpLoading = new System.Windows.Forms.GroupBox();
            this.txtPartitionLoad = new System.Windows.Forms.TextBox();
            this.txtDeadLoad = new System.Windows.Forms.TextBox();
            this.txtImpLoad = new System.Windows.Forms.TextBox();
            this.lblPartitionLoad = new System.Windows.Forms.Label();
            this.lblDeadLoad = new System.Windows.Forms.Label();
            this.lblImpLoad = new System.Windows.Forms.Label();
            this.grpBuildingDims = new System.Windows.Forms.GroupBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtGridY = new System.Windows.Forms.TextBox();
            this.txtColDim = new System.Windows.Forms.TextBox();
            this.txtFloorToFloorHeight = new System.Windows.Forms.TextBox();
            this.txtNumStories = new System.Windows.Forms.TextBox();
            this.txtLx = new System.Windows.Forms.TextBox();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.txtGridX = new System.Windows.Forms.TextBox();
            this.lblColDim = new System.Windows.Forms.Label();
            this.lblFloorToFloorHeight = new System.Windows.Forms.Label();
            this.lblNumStories = new System.Windows.Forms.Label();
            this.lblLx = new System.Windows.Forms.Label();
            this.lblLy = new System.Windows.Forms.Label();
            this.lblGrid = new System.Windows.Forms.Label();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.dgvSchedule1 = new System.Windows.Forms.DataGridView();
            this.colMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoMembers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembersEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShapeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShapeA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShapeB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShapeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCtrlMainForm.SuspendLayout();
            this.tabDesign.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpMaterialPricing.SuspendLayout();
            this.grpConcreteSpec.SuspendLayout();
            this.grpTransport.SuspendLayout();
            this.grpLoading.SuspendLayout();
            this.grpBuildingDims.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlMainForm
            // 
            this.tabCtrlMainForm.Controls.Add(this.tabDesign);
            this.tabCtrlMainForm.Controls.Add(this.tabSchedule);
            this.tabCtrlMainForm.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMainForm.Name = "tabCtrlMainForm";
            this.tabCtrlMainForm.SelectedIndex = 0;
            this.tabCtrlMainForm.Size = new System.Drawing.Size(633, 472);
            this.tabCtrlMainForm.TabIndex = 0;
            // 
            // tabDesign
            // 
            this.tabDesign.Controls.Add(this.btnFinish);
            this.tabDesign.Controls.Add(this.btnDesign);
            this.tabDesign.Controls.Add(this.grpOutput);
            this.tabDesign.Controls.Add(this.grpMaterialPricing);
            this.tabDesign.Controls.Add(this.grpConcreteSpec);
            this.tabDesign.Controls.Add(this.grpTransport);
            this.tabDesign.Controls.Add(this.grpLoading);
            this.tabDesign.Controls.Add(this.grpBuildingDims);
            this.tabDesign.Location = new System.Drawing.Point(4, 22);
            this.tabDesign.Name = "tabDesign";
            this.tabDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tabDesign.Size = new System.Drawing.Size(625, 446);
            this.tabDesign.TabIndex = 0;
            this.tabDesign.Text = "Design";
            this.tabDesign.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(273, 414);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnDesign
            // 
            this.btnDesign.Location = new System.Drawing.Point(180, 414);
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.Size = new System.Drawing.Size(75, 23);
            this.btnDesign.TabIndex = 6;
            this.btnDesign.Text = "Design";
            this.btnDesign.UseVisualStyleBackColor = true;
            this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.txtMaterialCost);
            this.grpOutput.Controls.Add(this.txtThermalMass);
            this.grpOutput.Controls.Add(this.txtSlabDepth);
            this.grpOutput.Controls.Add(this.lblThermalMass);
            this.grpOutput.Controls.Add(this.lblMaterialCost);
            this.grpOutput.Controls.Add(this.lblSlabDepth);
            this.grpOutput.Location = new System.Drawing.Point(309, 308);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(300, 100);
            this.grpOutput.TabIndex = 5;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Basic Design Output";
            // 
            // txtMaterialCost
            // 
            this.txtMaterialCost.Location = new System.Drawing.Point(152, 82);
            this.txtMaterialCost.Name = "txtMaterialCost";
            this.txtMaterialCost.Size = new System.Drawing.Size(70, 20);
            this.txtMaterialCost.TabIndex = 24;
            // 
            // txtThermalMass
            // 
            this.txtThermalMass.Location = new System.Drawing.Point(152, 53);
            this.txtThermalMass.Name = "txtThermalMass";
            this.txtThermalMass.Size = new System.Drawing.Size(70, 20);
            this.txtThermalMass.TabIndex = 23;
            // 
            // txtSlabDepth
            // 
            this.txtSlabDepth.Location = new System.Drawing.Point(152, 24);
            this.txtSlabDepth.Name = "txtSlabDepth";
            this.txtSlabDepth.Size = new System.Drawing.Size(70, 20);
            this.txtSlabDepth.TabIndex = 22;
            // 
            // lblThermalMass
            // 
            this.lblThermalMass.AutoSize = true;
            this.lblThermalMass.Location = new System.Drawing.Point(15, 56);
            this.lblThermalMass.Name = "lblThermalMass";
            this.lblThermalMass.Size = new System.Drawing.Size(73, 13);
            this.lblThermalMass.TabIndex = 17;
            this.lblThermalMass.Text = "Thermal Mass";
            // 
            // lblMaterialCost
            // 
            this.lblMaterialCost.AutoSize = true;
            this.lblMaterialCost.Location = new System.Drawing.Point(15, 85);
            this.lblMaterialCost.Name = "lblMaterialCost";
            this.lblMaterialCost.Size = new System.Drawing.Size(68, 13);
            this.lblMaterialCost.TabIndex = 16;
            this.lblMaterialCost.Text = "Material Cost";
            // 
            // lblSlabDepth
            // 
            this.lblSlabDepth.AutoSize = true;
            this.lblSlabDepth.Location = new System.Drawing.Point(15, 27);
            this.lblSlabDepth.Name = "lblSlabDepth";
            this.lblSlabDepth.Size = new System.Drawing.Size(60, 13);
            this.lblSlabDepth.TabIndex = 15;
            this.lblSlabDepth.Text = "Slab Depth";
            // 
            // grpMaterialPricing
            // 
            this.grpMaterialPricing.Controls.Add(this.txtSteelPrice);
            this.grpMaterialPricing.Controls.Add(this.txtConcretePrice);
            this.grpMaterialPricing.Controls.Add(this.lblSteelPrice);
            this.grpMaterialPricing.Controls.Add(this.lblConcretePrice);
            this.grpMaterialPricing.Location = new System.Drawing.Point(309, 235);
            this.grpMaterialPricing.Name = "grpMaterialPricing";
            this.grpMaterialPricing.Size = new System.Drawing.Size(300, 67);
            this.grpMaterialPricing.TabIndex = 4;
            this.grpMaterialPricing.TabStop = false;
            this.grpMaterialPricing.Text = "Material Pricing";
            // 
            // txtSteelPrice
            // 
            this.txtSteelPrice.Location = new System.Drawing.Point(152, 37);
            this.txtSteelPrice.Name = "txtSteelPrice";
            this.txtSteelPrice.Size = new System.Drawing.Size(70, 20);
            this.txtSteelPrice.TabIndex = 21;
            // 
            // txtConcretePrice
            // 
            this.txtConcretePrice.Location = new System.Drawing.Point(152, 13);
            this.txtConcretePrice.Name = "txtConcretePrice";
            this.txtConcretePrice.Size = new System.Drawing.Size(70, 20);
            this.txtConcretePrice.TabIndex = 20;
            // 
            // lblSteelPrice
            // 
            this.lblSteelPrice.AutoSize = true;
            this.lblSteelPrice.Location = new System.Drawing.Point(19, 45);
            this.lblSteelPrice.Name = "lblSteelPrice";
            this.lblSteelPrice.Size = new System.Drawing.Size(31, 13);
            this.lblSteelPrice.TabIndex = 16;
            this.lblSteelPrice.Text = "Steel";
            // 
            // lblConcretePrice
            // 
            this.lblConcretePrice.AutoSize = true;
            this.lblConcretePrice.Location = new System.Drawing.Point(19, 16);
            this.lblConcretePrice.Name = "lblConcretePrice";
            this.lblConcretePrice.Size = new System.Drawing.Size(50, 13);
            this.lblConcretePrice.TabIndex = 15;
            this.lblConcretePrice.Text = "Concrete";
            // 
            // grpConcreteSpec
            // 
            this.grpConcreteSpec.Controls.Add(this.cmbConcreteGrade);
            this.grpConcreteSpec.Controls.Add(this.txtPcCem);
            this.grpConcreteSpec.Controls.Add(this.txtPcGGBS);
            this.grpConcreteSpec.Controls.Add(this.txtPcAgg);
            this.grpConcreteSpec.Controls.Add(this.txtPcWater);
            this.grpConcreteSpec.Controls.Add(this.txtFck);
            this.grpConcreteSpec.Controls.Add(this.txtCover);
            this.grpConcreteSpec.Controls.Add(this.lblConcreteGrade);
            this.grpConcreteSpec.Controls.Add(this.lblPcCem);
            this.grpConcreteSpec.Controls.Add(this.lblPcGGBS);
            this.grpConcreteSpec.Controls.Add(this.lblPcAgg);
            this.grpConcreteSpec.Controls.Add(this.lblPcWater);
            this.grpConcreteSpec.Controls.Add(this.lblFck);
            this.grpConcreteSpec.Controls.Add(this.lblCover);
            this.grpConcreteSpec.Location = new System.Drawing.Point(309, 6);
            this.grpConcreteSpec.Name = "grpConcreteSpec";
            this.grpConcreteSpec.Size = new System.Drawing.Size(300, 224);
            this.grpConcreteSpec.TabIndex = 3;
            this.grpConcreteSpec.TabStop = false;
            this.grpConcreteSpec.Text = "Concrete Spec";
            // 
            // cmbConcreteGrade
            // 
            this.cmbConcreteGrade.FormattingEnabled = true;
            this.cmbConcreteGrade.Location = new System.Drawing.Point(152, 47);
            this.cmbConcreteGrade.Name = "cmbConcreteGrade";
            this.cmbConcreteGrade.Size = new System.Drawing.Size(70, 21);
            this.cmbConcreteGrade.TabIndex = 20;
            // 
            // txtPcCem
            // 
            this.txtPcCem.Location = new System.Drawing.Point(152, 192);
            this.txtPcCem.Name = "txtPcCem";
            this.txtPcCem.Size = new System.Drawing.Size(70, 20);
            this.txtPcCem.TabIndex = 19;
            // 
            // txtPcGGBS
            // 
            this.txtPcGGBS.Location = new System.Drawing.Point(152, 163);
            this.txtPcGGBS.Name = "txtPcGGBS";
            this.txtPcGGBS.Size = new System.Drawing.Size(70, 20);
            this.txtPcGGBS.TabIndex = 18;
            // 
            // txtPcAgg
            // 
            this.txtPcAgg.Location = new System.Drawing.Point(152, 134);
            this.txtPcAgg.Name = "txtPcAgg";
            this.txtPcAgg.Size = new System.Drawing.Size(70, 20);
            this.txtPcAgg.TabIndex = 17;
            // 
            // txtPcWater
            // 
            this.txtPcWater.Location = new System.Drawing.Point(152, 105);
            this.txtPcWater.Name = "txtPcWater";
            this.txtPcWater.Size = new System.Drawing.Size(70, 20);
            this.txtPcWater.TabIndex = 16;
            // 
            // txtFck
            // 
            this.txtFck.Location = new System.Drawing.Point(152, 76);
            this.txtFck.Name = "txtFck";
            this.txtFck.Size = new System.Drawing.Size(70, 20);
            this.txtFck.TabIndex = 15;
            // 
            // txtCover
            // 
            this.txtCover.Location = new System.Drawing.Point(152, 18);
            this.txtCover.Name = "txtCover";
            this.txtCover.Size = new System.Drawing.Size(70, 20);
            this.txtCover.TabIndex = 8;
            // 
            // lblConcreteGrade
            // 
            this.lblConcreteGrade.AutoSize = true;
            this.lblConcreteGrade.Location = new System.Drawing.Point(15, 50);
            this.lblConcreteGrade.Name = "lblConcreteGrade";
            this.lblConcreteGrade.Size = new System.Drawing.Size(36, 13);
            this.lblConcreteGrade.TabIndex = 14;
            this.lblConcreteGrade.Text = "Grade";
            // 
            // lblPcCem
            // 
            this.lblPcCem.AutoSize = true;
            this.lblPcCem.Location = new System.Drawing.Point(15, 195);
            this.lblPcCem.Name = "lblPcCem";
            this.lblPcCem.Size = new System.Drawing.Size(39, 13);
            this.lblPcCem.TabIndex = 13;
            this.lblPcCem.Text = "% Cem";
            // 
            // lblPcGGBS
            // 
            this.lblPcGGBS.AutoSize = true;
            this.lblPcGGBS.Location = new System.Drawing.Point(15, 166);
            this.lblPcGGBS.Name = "lblPcGGBS";
            this.lblPcGGBS.Size = new System.Drawing.Size(48, 13);
            this.lblPcGGBS.TabIndex = 12;
            this.lblPcGGBS.Text = "% GGBS";
            // 
            // lblPcAgg
            // 
            this.lblPcAgg.AutoSize = true;
            this.lblPcAgg.Location = new System.Drawing.Point(15, 137);
            this.lblPcAgg.Name = "lblPcAgg";
            this.lblPcAgg.Size = new System.Drawing.Size(37, 13);
            this.lblPcAgg.TabIndex = 11;
            this.lblPcAgg.Text = "% Agg";
            // 
            // lblPcWater
            // 
            this.lblPcWater.AutoSize = true;
            this.lblPcWater.Location = new System.Drawing.Point(15, 108);
            this.lblPcWater.Name = "lblPcWater";
            this.lblPcWater.Size = new System.Drawing.Size(47, 13);
            this.lblPcWater.TabIndex = 10;
            this.lblPcWater.Text = "% Water";
            // 
            // lblFck
            // 
            this.lblFck.AutoSize = true;
            this.lblFck.Location = new System.Drawing.Point(15, 79);
            this.lblFck.Name = "lblFck";
            this.lblFck.Size = new System.Drawing.Size(25, 13);
            this.lblFck.TabIndex = 9;
            this.lblFck.Text = "Fck";
            // 
            // lblCover
            // 
            this.lblCover.AutoSize = true;
            this.lblCover.Location = new System.Drawing.Point(15, 21);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(35, 13);
            this.lblCover.TabIndex = 8;
            this.lblCover.Text = "Cover";
            // 
            // grpTransport
            // 
            this.grpTransport.Controls.Add(this.txtGGBSBatch);
            this.grpTransport.Controls.Add(this.lblGGBSToBatch);
            this.grpTransport.Controls.Add(this.txtBatchSite);
            this.grpTransport.Controls.Add(this.lblBatchToSite);
            this.grpTransport.Location = new System.Drawing.Point(3, 308);
            this.grpTransport.Name = "grpTransport";
            this.grpTransport.Size = new System.Drawing.Size(300, 100);
            this.grpTransport.TabIndex = 2;
            this.grpTransport.TabStop = false;
            this.grpTransport.Text = "Transportation";
            // 
            // txtGGBSBatch
            // 
            this.txtGGBSBatch.Location = new System.Drawing.Point(155, 56);
            this.txtGGBSBatch.Name = "txtGGBSBatch";
            this.txtGGBSBatch.Size = new System.Drawing.Size(70, 20);
            this.txtGGBSBatch.TabIndex = 3;
            // 
            // lblGGBSToBatch
            // 
            this.lblGGBSToBatch.AutoSize = true;
            this.lblGGBSToBatch.Location = new System.Drawing.Point(3, 59);
            this.lblGGBSToBatch.Name = "lblGGBSToBatch";
            this.lblGGBSToBatch.Size = new System.Drawing.Size(134, 13);
            this.lblGGBSToBatch.TabIndex = 2;
            this.lblGGBSToBatch.Text = "GGBS Plant to Batch Plant";
            // 
            // txtBatchSite
            // 
            this.txtBatchSite.Location = new System.Drawing.Point(155, 19);
            this.txtBatchSite.Name = "txtBatchSite";
            this.txtBatchSite.Size = new System.Drawing.Size(70, 20);
            this.txtBatchSite.TabIndex = 1;
            // 
            // lblBatchToSite
            // 
            this.lblBatchToSite.AutoSize = true;
            this.lblBatchToSite.Location = new System.Drawing.Point(3, 22);
            this.lblBatchToSite.Name = "lblBatchToSite";
            this.lblBatchToSite.Size = new System.Drawing.Size(95, 13);
            this.lblBatchToSite.TabIndex = 0;
            this.lblBatchToSite.Text = "Batch Plant to Site";
            // 
            // grpLoading
            // 
            this.grpLoading.Controls.Add(this.txtPartitionLoad);
            this.grpLoading.Controls.Add(this.txtDeadLoad);
            this.grpLoading.Controls.Add(this.txtImpLoad);
            this.grpLoading.Controls.Add(this.lblPartitionLoad);
            this.grpLoading.Controls.Add(this.lblDeadLoad);
            this.grpLoading.Controls.Add(this.lblImpLoad);
            this.grpLoading.Location = new System.Drawing.Point(3, 191);
            this.grpLoading.Name = "grpLoading";
            this.grpLoading.Size = new System.Drawing.Size(300, 111);
            this.grpLoading.TabIndex = 1;
            this.grpLoading.TabStop = false;
            this.grpLoading.Text = "Loading";
            // 
            // txtPartitionLoad
            // 
            this.txtPartitionLoad.Location = new System.Drawing.Point(155, 79);
            this.txtPartitionLoad.Name = "txtPartitionLoad";
            this.txtPartitionLoad.Size = new System.Drawing.Size(70, 20);
            this.txtPartitionLoad.TabIndex = 5;
            // 
            // txtDeadLoad
            // 
            this.txtDeadLoad.Location = new System.Drawing.Point(155, 53);
            this.txtDeadLoad.Name = "txtDeadLoad";
            this.txtDeadLoad.Size = new System.Drawing.Size(70, 20);
            this.txtDeadLoad.TabIndex = 4;
            // 
            // txtImpLoad
            // 
            this.txtImpLoad.Location = new System.Drawing.Point(155, 19);
            this.txtImpLoad.Name = "txtImpLoad";
            this.txtImpLoad.Size = new System.Drawing.Size(70, 20);
            this.txtImpLoad.TabIndex = 3;
            // 
            // lblPartitionLoad
            // 
            this.lblPartitionLoad.AutoSize = true;
            this.lblPartitionLoad.Location = new System.Drawing.Point(17, 84);
            this.lblPartitionLoad.Name = "lblPartitionLoad";
            this.lblPartitionLoad.Size = new System.Drawing.Size(72, 13);
            this.lblPartitionLoad.TabIndex = 2;
            this.lblPartitionLoad.Text = "Partition Load";
            // 
            // lblDeadLoad
            // 
            this.lblDeadLoad.AutoSize = true;
            this.lblDeadLoad.Location = new System.Drawing.Point(17, 56);
            this.lblDeadLoad.Name = "lblDeadLoad";
            this.lblDeadLoad.Size = new System.Drawing.Size(91, 13);
            this.lblDeadLoad.TabIndex = 1;
            this.lblDeadLoad.Text = "Super Dead Load";
            // 
            // lblImpLoad
            // 
            this.lblImpLoad.AutoSize = true;
            this.lblImpLoad.Location = new System.Drawing.Point(17, 26);
            this.lblImpLoad.Name = "lblImpLoad";
            this.lblImpLoad.Size = new System.Drawing.Size(88, 13);
            this.lblImpLoad.TabIndex = 0;
            this.lblImpLoad.Text = "Imposed Loading";
            // 
            // grpBuildingDims
            // 
            this.grpBuildingDims.Controls.Add(this.lblX);
            this.grpBuildingDims.Controls.Add(this.txtGridY);
            this.grpBuildingDims.Controls.Add(this.txtColDim);
            this.grpBuildingDims.Controls.Add(this.txtFloorToFloorHeight);
            this.grpBuildingDims.Controls.Add(this.txtNumStories);
            this.grpBuildingDims.Controls.Add(this.txtLx);
            this.grpBuildingDims.Controls.Add(this.txtLy);
            this.grpBuildingDims.Controls.Add(this.txtGridX);
            this.grpBuildingDims.Controls.Add(this.lblColDim);
            this.grpBuildingDims.Controls.Add(this.lblFloorToFloorHeight);
            this.grpBuildingDims.Controls.Add(this.lblNumStories);
            this.grpBuildingDims.Controls.Add(this.lblLx);
            this.grpBuildingDims.Controls.Add(this.lblLy);
            this.grpBuildingDims.Controls.Add(this.lblGrid);
            this.grpBuildingDims.Location = new System.Drawing.Point(0, 0);
            this.grpBuildingDims.Name = "grpBuildingDims";
            this.grpBuildingDims.Size = new System.Drawing.Size(300, 185);
            this.grpBuildingDims.TabIndex = 0;
            this.grpBuildingDims.TabStop = false;
            this.grpBuildingDims.Text = "Building Dimensions";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(185, 25);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(12, 13);
            this.lblX.TabIndex = 13;
            this.lblX.Text = "x";
            // 
            // txtGridY
            // 
            this.txtGridY.Location = new System.Drawing.Point(198, 20);
            this.txtGridY.Name = "txtGridY";
            this.txtGridY.Size = new System.Drawing.Size(27, 20);
            this.txtGridY.TabIndex = 12;
            // 
            // txtColDim
            // 
            this.txtColDim.Location = new System.Drawing.Point(155, 152);
            this.txtColDim.Name = "txtColDim";
            this.txtColDim.Size = new System.Drawing.Size(70, 20);
            this.txtColDim.TabIndex = 11;
            // 
            // txtFloorToFloorHeight
            // 
            this.txtFloorToFloorHeight.Location = new System.Drawing.Point(155, 126);
            this.txtFloorToFloorHeight.Name = "txtFloorToFloorHeight";
            this.txtFloorToFloorHeight.Size = new System.Drawing.Size(70, 20);
            this.txtFloorToFloorHeight.TabIndex = 10;
            // 
            // txtNumStories
            // 
            this.txtNumStories.Location = new System.Drawing.Point(155, 99);
            this.txtNumStories.Name = "txtNumStories";
            this.txtNumStories.Size = new System.Drawing.Size(70, 20);
            this.txtNumStories.TabIndex = 9;
            // 
            // txtLx
            // 
            this.txtLx.Location = new System.Drawing.Point(155, 73);
            this.txtLx.Name = "txtLx";
            this.txtLx.Size = new System.Drawing.Size(70, 20);
            this.txtLx.TabIndex = 8;
            // 
            // txtLy
            // 
            this.txtLy.Location = new System.Drawing.Point(155, 47);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(70, 20);
            this.txtLy.TabIndex = 7;
            // 
            // txtGridX
            // 
            this.txtGridX.Location = new System.Drawing.Point(155, 20);
            this.txtGridX.Name = "txtGridX";
            this.txtGridX.Size = new System.Drawing.Size(27, 20);
            this.txtGridX.TabIndex = 6;
            // 
            // lblColDim
            // 
            this.lblColDim.AutoSize = true;
            this.lblColDim.Location = new System.Drawing.Point(17, 155);
            this.lblColDim.Name = "lblColDim";
            this.lblColDim.Size = new System.Drawing.Size(102, 13);
            this.lblColDim.TabIndex = 5;
            this.lblColDim.Text = "Column Side Length";
            // 
            // lblFloorToFloorHeight
            // 
            this.lblFloorToFloorHeight.AutoSize = true;
            this.lblFloorToFloorHeight.Location = new System.Drawing.Point(17, 129);
            this.lblFloorToFloorHeight.Name = "lblFloorToFloorHeight";
            this.lblFloorToFloorHeight.Size = new System.Drawing.Size(102, 13);
            this.lblFloorToFloorHeight.TabIndex = 4;
            this.lblFloorToFloorHeight.Text = "Floor to Floor Height";
            // 
            // lblNumStories
            // 
            this.lblNumStories.AutoSize = true;
            this.lblNumStories.Location = new System.Drawing.Point(17, 102);
            this.lblNumStories.Name = "lblNumStories";
            this.lblNumStories.Size = new System.Drawing.Size(91, 13);
            this.lblNumStories.TabIndex = 3;
            this.lblNumStories.Text = "Number of Stories";
            // 
            // lblLx
            // 
            this.lblLx.AutoSize = true;
            this.lblLx.Location = new System.Drawing.Point(17, 76);
            this.lblLx.Name = "lblLx";
            this.lblLx.Size = new System.Drawing.Size(18, 13);
            this.lblLx.TabIndex = 2;
            this.lblLx.Text = "Lx";
            // 
            // lblLy
            // 
            this.lblLy.AutoSize = true;
            this.lblLy.Location = new System.Drawing.Point(17, 50);
            this.lblLy.Name = "lblLy";
            this.lblLy.Size = new System.Drawing.Size(18, 13);
            this.lblLy.TabIndex = 1;
            this.lblLy.Text = "Ly";
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Location = new System.Drawing.Point(17, 23);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(26, 13);
            this.lblGrid.TabIndex = 0;
            this.lblGrid.Text = "Grid";
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.dgvSchedule1);
            this.tabSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(625, 446);
            this.tabSchedule.TabIndex = 1;
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // dgvSchedule1
            // 
            this.dgvSchedule1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMember,
            this.colBarMark,
            this.colTypeSize,
            this.colNoMembers,
            this.colMembersEach,
            this.colTotalNo,
            this.colBarLength,
            this.colShapeCode,
            this.colShapeA,
            this.colShapeB,
            this.colShapeC});
            this.dgvSchedule1.Location = new System.Drawing.Point(0, 0);
            this.dgvSchedule1.Name = "dgvSchedule1";
            this.dgvSchedule1.Size = new System.Drawing.Size(625, 446);
            this.dgvSchedule1.TabIndex = 0;
            // 
            // colMember
            // 
            this.colMember.HeaderText = "Member";
            this.colMember.Name = "colMember";
            this.colMember.Width = 50;
            // 
            // colBarMark
            // 
            this.colBarMark.HeaderText = "Bar Mark";
            this.colBarMark.Name = "colBarMark";
            this.colBarMark.Width = 75;
            // 
            // colTypeSize
            // 
            this.colTypeSize.HeaderText = "Type + Size";
            this.colTypeSize.Name = "colTypeSize";
            this.colTypeSize.Width = 90;
            // 
            // colNoMembers
            // 
            this.colNoMembers.HeaderText = "No. of Members";
            this.colNoMembers.Name = "colNoMembers";
            this.colNoMembers.Width = 50;
            // 
            // colMembersEach
            // 
            this.colMembersEach.HeaderText = "Members in Each";
            this.colMembersEach.Name = "colMembersEach";
            this.colMembersEach.Width = 50;
            // 
            // colTotalNo
            // 
            this.colTotalNo.HeaderText = "Total No.";
            this.colTotalNo.Name = "colTotalNo";
            this.colTotalNo.Width = 75;
            // 
            // colBarLength
            // 
            this.colBarLength.HeaderText = "Bar Length";
            this.colBarLength.Name = "colBarLength";
            this.colBarLength.Width = 50;
            // 
            // colShapeCode
            // 
            this.colShapeCode.HeaderText = "Shape Code";
            this.colShapeCode.Name = "colShapeCode";
            this.colShapeCode.Width = 50;
            // 
            // colShapeA
            // 
            this.colShapeA.HeaderText = "A";
            this.colShapeA.Name = "colShapeA";
            this.colShapeA.Width = 30;
            // 
            // colShapeB
            // 
            this.colShapeB.HeaderText = "B";
            this.colShapeB.Name = "colShapeB";
            this.colShapeB.Width = 30;
            // 
            // colShapeC
            // 
            this.colShapeC.HeaderText = "C";
            this.colShapeC.Name = "colShapeC";
            this.colShapeC.Width = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 472);
            this.Controls.Add(this.tabCtrlMainForm);
            this.Name = "MainForm";
            this.Text = "Kawnkreet";
            this.tabCtrlMainForm.ResumeLayout(false);
            this.tabDesign.ResumeLayout(false);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpMaterialPricing.ResumeLayout(false);
            this.grpMaterialPricing.PerformLayout();
            this.grpConcreteSpec.ResumeLayout(false);
            this.grpConcreteSpec.PerformLayout();
            this.grpTransport.ResumeLayout(false);
            this.grpTransport.PerformLayout();
            this.grpLoading.ResumeLayout(false);
            this.grpLoading.PerformLayout();
            this.grpBuildingDims.ResumeLayout(false);
            this.grpBuildingDims.PerformLayout();
            this.tabSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule1)).EndInit();
            this.ResumeLayout(false);

            SetSampleInput();

        }

        #endregion

        private System.Windows.Forms.TabPage tabDesign;
        private System.Windows.Forms.GroupBox grpBuildingDims;
        private System.Windows.Forms.GroupBox grpTransport;
        private System.Windows.Forms.GroupBox grpLoading;
        private System.Windows.Forms.Label lblBatchToSite;
        private System.Windows.Forms.Label lblGGBSToBatch;
        private System.Windows.Forms.Label lblPartitionLoad;
        private System.Windows.Forms.Label lblDeadLoad;
        private System.Windows.Forms.Label lblImpLoad;
        private System.Windows.Forms.Label lblLy;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.GroupBox grpMaterialPricing;
        private System.Windows.Forms.GroupBox grpConcreteSpec;

        public System.Windows.Forms.TextBox TxtLx
        {
            get { return txtLx; }
            set { txtLx = value; }
        }
        private System.Windows.Forms.Label lblColDim;
        private System.Windows.Forms.Label lblFloorToFloorHeight;
        private System.Windows.Forms.Label lblNumStories;
        private System.Windows.Forms.Label lblLx;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnDesign;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblConcreteGrade;
        private System.Windows.Forms.Label lblPcCem;
        private System.Windows.Forms.Label lblPcGGBS;
        private System.Windows.Forms.Label lblPcAgg;
        private System.Windows.Forms.Label lblPcWater;
        private System.Windows.Forms.Label lblFck;
        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.Label lblThermalMass;
        private System.Windows.Forms.Label lblMaterialCost;
        private System.Windows.Forms.Label lblSlabDepth;
        private System.Windows.Forms.Label lblSteelPrice;
        private System.Windows.Forms.Label lblConcretePrice;
        private System.Windows.Forms.Label lblX;
        public System.Windows.Forms.TextBox txtBatchSite;
        public System.Windows.Forms.TextBox txtGGBSBatch;
        public System.Windows.Forms.TextBox txtPartitionLoad;
        public System.Windows.Forms.TextBox txtDeadLoad;
        public System.Windows.Forms.TextBox txtImpLoad;
        public System.Windows.Forms.TextBox txtColDim;
        public System.Windows.Forms.TextBox txtFloorToFloorHeight;
        public System.Windows.Forms.TextBox txtNumStories;
        public System.Windows.Forms.TextBox txtLx;
        public System.Windows.Forms.TextBox txtLy;
        public System.Windows.Forms.TextBox txtGridX;
        public System.Windows.Forms.TextBox txtMaterialCost;
        public System.Windows.Forms.TextBox txtThermalMass;
        public System.Windows.Forms.TextBox txtSlabDepth;
        public System.Windows.Forms.TextBox txtSteelPrice;
        public System.Windows.Forms.TextBox txtConcretePrice;
        public System.Windows.Forms.TextBox txtPcCem;
        public System.Windows.Forms.TextBox txtPcGGBS;
        public System.Windows.Forms.TextBox txtPcAgg;
        public System.Windows.Forms.TextBox txtPcWater;
        public System.Windows.Forms.TextBox txtFck;
        public System.Windows.Forms.TextBox txtCover;
        public System.Windows.Forms.ComboBox cmbConcreteGrade;
        public System.Windows.Forms.TextBox txtGridY;

        public void GetInput(InputData data)
        {
            data.GridX = Int32.Parse(txtGridX.Text);
            data.GridY = Int32.Parse(txtGridY.Text);
            data.Ly = Int32.Parse(txtLy.Text);
            data.Lx = Int32.Parse(txtLx.Text);
            data.NumStories = Int32.Parse(txtNumStories.Text);            
            data.FloorToFloorHeight = Int32.Parse(txtFloorToFloorHeight.Text);
            data.ColDim = Int32.Parse(txtColDim.Text);
            data.ImpLoad = Double.Parse(txtImpLoad.Text);
            data.DeadLoad = Double.Parse(txtDeadLoad.Text);
            data.PartitionLoad = Int32.Parse(txtPartitionLoad.Text);
            data.BatchSite = Int32.Parse(txtBatchSite.Text);
            data.GGBSBatch = Int32.Parse(txtGGBSBatch.Text);
            data.Cover = Int32.Parse(txtCover.Text);
            data.ConcreteGrade = Int32.Parse(cmbConcreteGrade.Text);
            data.Fck = Int32.Parse(txtFck.Text);
            data.PcWater = Int32.Parse(txtPcWater.Text);
            data.PcAgg = Int32.Parse(txtPcAgg.Text);
            data.PcGGBS = Int32.Parse(txtPcGGBS.Text);
            data.PcCem = Int32.Parse(txtPcCem.Text);
            data.ConcretePrice = Int32.Parse(txtConcretePrice.Text);
            data.SteelPrice = Int32.Parse(txtSteelPrice.Text);
            //data.SlabDepth = Int32.Parse(txtSlabDepth.Text);
            //data.ThermalMass = Int32.Parse(txtThermalMass.Text);
            //data.MaterialCost = Int32.Parse(txtMaterialCost.Text);
        }
        public void SetSampleInput()
        {
            txtGridX.Text = "7";
            txtGridY.Text = "7";
            txtLy.Text = "6";
            txtLx.Text = "5";
            txtNumStories.Text = "5";
            txtFloorToFloorHeight.Text = "5";
            txtColDim.Text = "400";
            txtImpLoad.Text = "2";
            txtDeadLoad.Text = "2";
            txtPartitionLoad.Text = "1";
            txtBatchSite.Text = "5";
            txtGGBSBatch.Text = "5";
            txtCover.Text = "25";
            cmbConcreteGrade.Text = "40";
            txtFck.Text = "35";
            txtPcWater.Text = "5";
            txtPcAgg.Text = "5";
            txtPcGGBS.Text = "5";
            txtPcCem.Text = "5";
            txtConcretePrice.Text = "5";
            txtSteelPrice.Text = "5";
        }

        public void SetDGVData()
        { 

            dgvSchedule1.Rows[0].Cells[1].Value = "FUck";
        
        }

        private System.Windows.Forms.TabPage tabSchedule;
        public System.Windows.Forms.TabControl tabCtrlMainForm;
        public System.Windows.Forms.DataGridView dgvSchedule1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembersEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShapeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShapeA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShapeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShapeC;
    }    
}

