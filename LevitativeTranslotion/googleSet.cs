using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevitativeTranslotion
{
    public partial class googleSet : Form
    {
        string[,] tran = new string[,] {
            {"自動偵測","土耳其文","繁體中文","丹麥文","日文","世界語","加里西亞文","加泰羅尼亞文","卡納達文","布爾文","白俄羅斯文","立陶宛文","冰島文","匈牙利文","印尼文","印度文","印度古哈拉地文","西班牙文","克羅埃西亞文","希伯來文","希臘文","孟加拉文","拉脫維亞文","法文","波斯文","波蘭文","芬蘭文","阿拉伯文","阿爾巴尼亞文","俄文","保加利亞文","威爾斯文","英文","挪威文","泰文","泰米爾文","泰盧固文","海地克里奧文","烏克蘭文","烏爾都文","馬耳他文","馬來文","馬其頓文","馬拉地文","捷克文","荷蘭文","喬治亞文","斯瓦希里文","斯洛伐克文","斯洛維尼亞文","菲律賓文","越南文","愛沙尼亞文","愛爾蘭文","瑞典文","義大利文","葡萄牙文","德文","韓文","羅馬尼亞文"},
            {"auto","tr","zh-TW","da","ja","eo","gl","ca","kn","af","be","lt","is","hu","id","hi","gu","es","hr","iw","el","bn","lv","fr","fa","pl","fi","ar","sq","ru","bg","cy","en","no","th","ta","te","ht","uk","ur","mt","ms","mk","mr","cs","nl","ka","sw","sk","sl","tl","vi","et","ga","sv","it","pt","de","ko","ro"} };

        public googleSet()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
        }

        public SetConfig returnSitting()
        {
            SetConfig config = new SetConfig();
            return config;
        }

        private void googleSet_Load(object sender, EventArgs e)
        {
            //load sitting
        }
    }
}
