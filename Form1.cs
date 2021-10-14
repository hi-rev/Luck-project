using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luck_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = comboBox1.SelectedIndex.ToString();
            pictureBox1.Load("star" + index + ".jpg");
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            // 날짜가 선택될 때 데이터 출력
            label2.Text = ("선택한 날짜는 " + e.Start.Date.ToShortDateString() + " 입니다");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 랜덤 함수
            Random rand = new Random();

            // LuckArray 배열 생성
            string[] LuckArray = new string[]
                {"맞서 싸우기보다 한 발 물러서서 베풀어야 할 하루입니다."
                , "당신이 뜻하는 일을 추진하기에 매우 적절한 시기입니다."
                , "오늘 괜히 조급함으로 일을 그르치게 될 수도 있으니 급할수록 돌아가야합니다."
                , "몸도 마음도 여유롭고 물질적인 면에서도 여유로운 하루입니다."
                , "특별한 길운은 없지만 본인의 행동에 따라 행운이 따를 수도 있습니다."
                , "성숙한 사람으로 성장하기 위해서 시련을 견뎌야할 하루입니다."
                , "오늘 할 일을 내일로 미루고 내일 할일을 모레로 미루지 마세요."
                , "금전운이 나쁘니 돈 잃어버리지 않게 주의해주세요."
                , "하는 일에 막힘이 없고 성과도 좋은 하루가 되겠습니다."
                , "곤란한 일이 예상되는 하루입니다."
                , "능력 이상의 것이 이루어지거나 이루어질 조짐이 보이는 하루가 될 것입니다."
                , "열정적인 당신이 유연하고, 차분함까지 겸비하고 있다면, 동료들의 신임도 사게 될 것입니다."};

            int randomIndex = rand.Next(LuckArray.Length);

            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("별자리를 선택해주세요.", "안내");
            else if (label2.Text == "")
                MessageBox.Show("날짜를 선택해주세요!", "안내");
            else
                textBox1.Text = LuckArray[randomIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
