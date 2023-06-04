using CryptoBroker.Domain;
using CryptoBroker.Infrastructure.Brokers;

namespace TGCoinTZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            TreeNode treeNode5 = new TreeNode("Binance / Bybit");
            TreeNode treeNode6 = new TreeNode("KuCoin / ByBit");
            TreeNode treeNode7 = new TreeNode("Binance / KuCoin");
            TreeNode treeNode8 = new TreeNode("Биржевые пары", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            panel1 = new Panel();
            label1 = new Label();
            BinanceLabel = new Label();
            ByBitLabel = new Label();
            KuCoinLabel = new Label();
            BinanceStockLabel = new Label();
            KuCoinStockLabel = new Label();
            ByBitStockLabel = new Label();
            StockPair = new TreeView();
            ResultPairLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 146, 3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1593, 130);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(155, 193, 188);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 25.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1593, 130);
            label1.TabIndex = 0;
            label1.Text = "Курс BTC / USDT с разных бирж";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BinanceLabel
            // 
            BinanceLabel.BackColor = Color.FromArgb(230, 235, 224);
            BinanceLabel.Font = new Font("Tahoma", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            BinanceLabel.Location = new Point(61, 292);
            BinanceLabel.Margin = new Padding(4, 0, 4, 0);
            BinanceLabel.Name = "BinanceLabel";
            BinanceLabel.Size = new Size(180, 81);
            BinanceLabel.TabIndex = 1;
            BinanceLabel.Text = "Binance";
            BinanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ByBitLabel
            // 
            ByBitLabel.BackColor = Color.FromArgb(230, 235, 224);
            ByBitLabel.Font = new Font("Tahoma", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            ByBitLabel.Location = new Point(61, 646);
            ByBitLabel.Margin = new Padding(4, 0, 4, 0);
            ByBitLabel.Name = "ByBitLabel";
            ByBitLabel.Size = new Size(180, 81);
            ByBitLabel.TabIndex = 2;
            ByBitLabel.Text = "ByBit";
            ByBitLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KuCoinLabel
            // 
            KuCoinLabel.BackColor = Color.FromArgb(230, 235, 224);
            KuCoinLabel.Font = new Font("Tahoma", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            KuCoinLabel.Location = new Point(61, 471);
            KuCoinLabel.Margin = new Padding(4, 0, 4, 0);
            KuCoinLabel.Name = "KuCoinLabel";
            KuCoinLabel.Size = new Size(180, 81);
            KuCoinLabel.TabIndex = 3;
            KuCoinLabel.Text = "KuCoin";
            KuCoinLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BinanceStockLabel
            // 
            BinanceStockLabel.BackColor = Color.FromArgb(237, 106, 90);
            BinanceStockLabel.Location = new Point(371, 292);
            BinanceStockLabel.Margin = new Padding(4, 0, 4, 0);
            BinanceStockLabel.Name = "BinanceStockLabel";
            BinanceStockLabel.Size = new Size(236, 81);
            BinanceStockLabel.TabIndex = 4;
            BinanceStockLabel.Text = "0";
            BinanceStockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KuCoinStockLabel
            // 
            KuCoinStockLabel.BackColor = Color.FromArgb(237, 106, 90);
            KuCoinStockLabel.Location = new Point(371, 471);
            KuCoinStockLabel.Margin = new Padding(4, 0, 4, 0);
            KuCoinStockLabel.Name = "KuCoinStockLabel";
            KuCoinStockLabel.Size = new Size(236, 81);
            KuCoinStockLabel.TabIndex = 5;
            KuCoinStockLabel.Text = "0";
            KuCoinStockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ByBitStockLabel
            // 
            ByBitStockLabel.BackColor = Color.FromArgb(237, 106, 90);
            ByBitStockLabel.Location = new Point(371, 646);
            ByBitStockLabel.Margin = new Padding(4, 0, 4, 0);
            ByBitStockLabel.Name = "ByBitStockLabel";
            ByBitStockLabel.Size = new Size(236, 81);
            ByBitStockLabel.TabIndex = 6;
            ByBitStockLabel.Text = "0";
            ByBitStockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StockPair
            // 
            StockPair.AllowDrop = true;
            StockPair.BackColor = Color.FromArgb(244, 241, 187);
            StockPair.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            StockPair.Location = new Point(828, 292);
            StockPair.Margin = new Padding(4, 2, 4, 2);
            StockPair.Name = "StockPair";
            treeNode5.Name = "BinByb";
            treeNode5.Text = "Binance / Bybit";
            treeNode6.Name = "KucByb";
            treeNode6.Text = "KuCoin / ByBit";
            treeNode7.Name = "BinKuc";
            treeNode7.Text = "Binance / KuCoin";
            treeNode8.BackColor = Color.FromArgb(244, 241, 187);
            treeNode8.Name = "Relations";
            treeNode8.NodeFont = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            treeNode8.Text = "Биржевые пары";
            StockPair.Nodes.AddRange(new TreeNode[] { treeNode8 });
            StockPair.Size = new Size(472, 81);
            StockPair.TabIndex = 7;
            StockPair.AfterCollapse += treeView1_AfterCollapse;
            StockPair.BeforeExpand += treeView1_BeforeExpand;
            StockPair.AfterSelect += treeView1_AfterSelect;
            // 
            // ResultPairLabel
            // 
            ResultPairLabel.BackColor = Color.FromArgb(237, 106, 90);
            ResultPairLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ResultPairLabel.Location = new Point(828, 646);
            ResultPairLabel.Margin = new Padding(4, 0, 4, 0);
            ResultPairLabel.Name = "ResultPairLabel";
            ResultPairLabel.Size = new Size(475, 81);
            ResultPairLabel.TabIndex = 8;
            ResultPairLabel.Text = "Выбрать пару";
            ResultPairLabel.TextAlign = ContentAlignment.MiddleCenter;
            ResultPairLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 49, 48);
            ClientSize = new Size(1593, 1001);
            Controls.Add(ResultPairLabel);
            Controls.Add(StockPair);
            Controls.Add(ByBitStockLabel);
            Controls.Add(KuCoinStockLabel);
            Controls.Add(BinanceStockLabel);
            Controls.Add(KuCoinLabel);
            Controls.Add(ByBitLabel);
            Controls.Add(BinanceLabel);
            Controls.Add(panel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label BinanceLabel;
        private Label ByBitLabel;
        private Label KuCoinLabel;
        private Label BinanceStockLabel;
        private Label KuCoinStockLabel;
        private Label ByBitStockLabel;
        private TreeView StockPair;
        private Label ResultPairLabel;


    }
}