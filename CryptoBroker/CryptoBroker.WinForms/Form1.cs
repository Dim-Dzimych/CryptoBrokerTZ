using Binance.Net.Objects.Models;
using CryptoBroker.Domain;
using CryptoBroker.Infrastructure.Brokers;
using CryptoExchange.Net.CommonObjects;

namespace TGCoinTZ
{
    public partial class Form1 : Form
    {
        private readonly CurrencyWorker _currencyWorker;
        private string _binanceResult;
        private string _byBitResult;
        private string _kuCoinResult;
        private System.Windows.Forms.TreeViewEventArgs _node;
        public Form1()
        {
            InitializeComponent();
            //todo: add DI
            _currencyWorker = new CurrencyWorker();
            _currencyWorker.StartWorker();
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                ResultPairLabel.Visible = true;
                StockPair.Height = 260;
            }

        }
        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                StockPair.CollapseAll();
                StockPair.Height = 80;
                ResultPairLabel.Visible = false;
                ResultPairLabel.Text = "Выбрать пару";
                _node = null;
            }
        }
        private void treeView1_AfterSelect(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                _node = e;
                switch (e.Node.Name)
                {
                    case "Relations":
                        ResultPairLabel.Text = "Выбрать пару";
                        break;

                    case "BinByb":
                        ResultPairLabel.Text = BinanceStockLabel.Text + " / " + ByBitStockLabel.Text;
                        break;

                    case "KucByb":
                        ResultPairLabel.Text = KuCoinStockLabel.Text + " / " + ByBitStockLabel.Text; 
                        break;

                    case "BinKuc":
                        ResultPairLabel.Text = ByBitStockLabel.Text + " / " + KuCoinStockLabel.Text;
                        break;

                    default:
                        ResultPairLabel.Text = "Выбрать пару";
                        break;
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (5 * 1000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            var currencies = _currencyWorker.Currencies;
            currencies.TryGetValue(BrokerType.Binance, out var binance);
            currencies.TryGetValue(BrokerType.Bybit, out var bybit);
            currencies.TryGetValue(BrokerType.Kucoin, out var kucoin);

            ByBitStockLabel.Text = bybit.ToString();
            KuCoinStockLabel.Text = kucoin.ToString();
            BinanceStockLabel.Text = binance.ToString();
           
            if(_node != null)
            {
                treeView1_AfterSelect(sender, _node);
            }
        }

    }

}
