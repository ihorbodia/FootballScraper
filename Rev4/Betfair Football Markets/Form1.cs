using Betfair_Football_Markets.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betfair_Football_Markets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            outputGrid.CellFormatting += (s, e) =>
            {
                if (e.Value == null)
                {
                    return;
                }
                if (e.ColumnIndex > 0 && Regex.IsMatch(e.Value.ToString(), "[0-9]{3}.+"))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Lime;
                }
            };
        }

        private void LoadSettings()
        {
            try
            {
                apiCall.Text = Settings.Default.ApiCall;
                midBox.Text = Settings.Default.mID;
                pathBox.Text = Settings.Default.Path;
            }
            catch { }
        }
        private void SaveSettings()
        {
            try
            {
                Settings.Default.ApiCall = apiCall.Text;
                Settings.Default.mID = midBox.Text;
                Settings.Default.Path = pathBox.Text;

                Settings.Default.Save();
            }
            catch { }
        }

        List<MarketWrapper> serverList = new List<MarketWrapper>();
        List<ConstMarketWrapper> localList = new List<ConstMarketWrapper>();
        List<RatioData> rateList = new List<RatioData>();

        private async void reloadBtn_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private async Task ReloadData()
        {
            reloadBtn.Enabled = browseBtn.Enabled = recBtn.Enabled = false;
            try
            {
                var marketIds = midBox.Text;
                string url = String.Format("https://www.betfair.com/www/sports/exchange/readonly/v1/bymarket?alt=json&marketIds={0}&rollupModel=STAKE&types=RUNNER_DESCRIPTION,RUNNER_EXCHANGE_PRICES_BEST", marketIds);
                serverData.DataSource = null;
                serverList.Clear();
                await Scrapper.GetObjAsync<Market>(url, (m, obj) =>
                {
                    if (m == null)
                    {
                        foreach (var eventType in obj.EventTypes)
                            foreach (var eventNode in eventType.EventNodes)
                                foreach (var node in eventNode.MarketNodes)
                                {
                                    serverList.Add(new MarketWrapper(node));
                                }
                    }
                    else
                        MessageBox.Show("Something went wrong. Please check the IDs and your connection.\r\n" + m);
                });
                Invoke(new MethodInvoker(() =>
                {
                    serverData.DataSource = serverList;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reloadBtn.Enabled = browseBtn.Enabled = recBtn.Enabled = true;
            SaveSettings();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "Comma delimited|*.csv";

            if (dlg.ShowDialog() == DialogResult.OK)
                pathBox.Text = dlg.FileName;

            try
            {
                localGrid.DataSource = null;
                localList = CSVLoader.Read<ConstMarketWrapper>(pathBox.Text).ToList();
                localGrid.DataSource = localList;
                if (MessageBox.Show("Do you want to automatically update MarketIDs from the sheet?", "Auto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    midBox.Text = string.Join(",", localList.Select((m => m.MarketID)));
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Please close excel before loading the file.\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Make sure you save the file as a comma delimited csv\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SaveSettings();
        }

        private async void recBtn_Click(object sender, EventArgs e)
        {
            reloadBtn.Enabled = browseBtn.Enabled = recBtn.Enabled = false;
            try
            {
                if (MessageBox.Show("Do you want to reload from server?", "Auto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    await ReloadData();

                outputGrid.DataSource = null;
                rateList.Clear();
                foreach (var localValue in localList)
                {
                    var serValue = serverList.Find(x => x.MarketID == localValue.MarketID);
                    if (serValue == null)
                        continue;
                    double rt1, rt2, rt3, rt4, rt5, rt6, rt7, rt8, rt9, rt10, rt11, rt12, rt13, rt14, rt15, rt16, rt17, rt18, rt19, rt20;

                    rt1 = localValue.Option1 / serValue.Option1;
                    rt2 = localValue.Option2 / serValue.Option2;
                    rt3 = localValue.Option3 / serValue.Option3;
                    rt4 = localValue.Option4 / serValue.Option4;
                    rt5 = localValue.Option5 / serValue.Option5;
                    rt6 = localValue.Option6 / serValue.Option6;
                    rt7 = localValue.Option7 / serValue.Option7;
                    rt8 = localValue.Option8 / serValue.Option8;
                    rt9 = localValue.Option9 / serValue.Option9;
                    rt10 = localValue.Option10 / serValue.Option10;
                    rt11 = localValue.Option11 / serValue.Option11;
                    rt12 = localValue.Option12 / serValue.Option12;
                    rt13 = localValue.Option13 / serValue.Option13;
                    rt14 = localValue.Option14 / serValue.Option14;
                    rt15 = localValue.Option15 / serValue.Option15;
                    rt16 = localValue.Option16 / serValue.Option16;
                    rt17 = localValue.Option17 / serValue.Option17;
                    rt18 = localValue.Option18 / serValue.Option18;
                    rt19 = localValue.Option19 / serValue.Option19;
                    rt20 = localValue.Option20 / serValue.Option20;

                    double opt1, opt2, opt3, opt4, opt5, opt6, opt7, opt8, opt9, opt10, opt11, opt12, opt13, opt14, opt15, opt16, opt17, opt18, opt19, opt20;
                    opt1 = serValue.Option1;
                    opt2 = serValue.Option2;
                    opt3 = serValue.Option3;
                    opt4 = serValue.Option4;
                    opt5 = serValue.Option5;
                    opt6 = serValue.Option6;
                    opt7 = serValue.Option7;
                    opt8 = serValue.Option8;
                    opt9 = serValue.Option9;
                    opt10 = serValue.Option10;
                    opt11 = serValue.Option11;
                    opt12 = serValue.Option12;
                    opt13 = serValue.Option13;
                    opt14 = serValue.Option14;
                    opt15 = serValue.Option15;
                    opt16 = serValue.Option16;
                    opt17 = serValue.Option17;
                    opt18 = serValue.Option18;
                    opt19 = serValue.Option19;
                    opt20 = serValue.Option20;

                    string
                    rn1 = double.IsNaN(rt1) ? "-" : serValue.GetNode().Runners[0].Description.RunnerName,
                    rn2 = double.IsNaN(rt2) ? "-" : serValue.GetNode().Runners[1].Description.RunnerName,
                    rn3 = double.IsNaN(rt3) ? "-" : serValue.GetNode().Runners[2].Description.RunnerName,
                    rn4 = double.IsNaN(rt4) ? "-" : serValue.GetNode().Runners[3].Description.RunnerName,
                    rn5 = double.IsNaN(rt5) ? "-" : serValue.GetNode().Runners[4].Description.RunnerName,
                    rn6 = double.IsNaN(rt6) ? "-" : serValue.GetNode().Runners[5].Description.RunnerName,
                    rn7 = double.IsNaN(rt7) ? "-" : serValue.GetNode().Runners[6].Description.RunnerName,
                    rn8 = double.IsNaN(rt8) ? "-" : serValue.GetNode().Runners[7].Description.RunnerName,
                    rn9 = double.IsNaN(rt9) ? "-" : serValue.GetNode().Runners[8].Description.RunnerName,
                    rn10 = double.IsNaN(rt10) ? "-" : serValue.GetNode().Runners[9].Description.RunnerName,
                    rn11 = double.IsNaN(rt11) ? "-" : serValue.GetNode().Runners[10].Description.RunnerName,
                    rn12 = double.IsNaN(rt12) ? "-" : serValue.GetNode().Runners[11].Description.RunnerName,
                    rn13 = double.IsNaN(rt13) ? "-" : serValue.GetNode().Runners[12].Description.RunnerName,
                    rn14 = double.IsNaN(rt14) ? "-" : serValue.GetNode().Runners[13].Description.RunnerName,
                    rn15 = double.IsNaN(rt15) ? "-" : serValue.GetNode().Runners[14].Description.RunnerName,
                    rn16 = double.IsNaN(rt16) ? "-" : serValue.GetNode().Runners[15].Description.RunnerName,
                    rn17 = double.IsNaN(rt17) ? "-" : serValue.GetNode().Runners[16].Description.RunnerName,
                    rn18 = double.IsNaN(rt18) ? "-" : serValue.GetNode().Runners[17].Description.RunnerName,
                    rn19 = double.IsNaN(rt19) ? "-" : serValue.GetNode().Runners[18].Description.RunnerName,
                    rn20 = double.IsNaN(rt20) ? "-" : serValue.GetNode().Runners[19].Description.RunnerName;

                    rateList.Add(new RatioData(rt1, rt2, rt3, rt4, rt5, rt6, rt7, rt8, rt9, rt10, rt11, rt12, rt13, rt14, rt15, rt16, rt17, rt18, rt19, rt20,
                        rn1, rn2, rn3, rn4, rn5, rn6, rn7, rn8, rn9, rn10, rn11, rn12, rn13, rn14, rn15, rn16, rn17, rn18, rn19, rn20, localValue.MarketID,
                        opt1, opt2, opt3, opt4, opt5, opt6, opt7, opt8, opt9, opt10, opt11, opt12, opt13, opt14, opt15, opt16, opt17, opt18, opt19, opt20));
                }

                if (excCheck.Checked)
                    rateList = rateList.Where(x => x.GetSortedData()[0] >= 1).ToList();

                rateList = rateList
                    .OrderByDescending(x => x.GetSortedData()[0])
                    .ThenByDescending(x => x.GetSortedData()[1])
                    .ThenByDescending(x => x.GetSortedData()[2])
                    .ToList();

                Invoke(new MethodInvoker(() =>
                {
                    outputGrid.DataSource = rateList;
                    
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reloadBtn.Enabled = browseBtn.Enabled = recBtn.Enabled = true;
        }

        private void outputGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (outputGrid.SelectedRows.Count == 1)
            {
                int idx = outputGrid.SelectedRows[0].Index;
                var obj = rateList[idx];
                var mid = obj.GetMarketID();

                foreach (DataGridViewRow row in localGrid.Rows)
                {
                    row.Selected = row.Cells[0].Value == mid;
                }
                foreach (DataGridViewRow row in serverData.Rows)
                {
                    row.Selected = row.Cells[0].Value.ToString() == mid.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
