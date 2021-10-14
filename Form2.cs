using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        MyLuckList LuckList;
        public Form2()
        {
            InitializeComponent();
            LuckList = new MyLuckList();

            foreach (Person i in LuckList)
            {
                listBox1.Items.Add(i.inName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txtGender = "";
            if (radioButton1.Checked == true)
                txtGender = "여";
            else
                txtGender = "남";

            Person p = new Person(textBox1.Text, txtGender, Convert.ToString(comboBox1.SelectedItem));

            textBox1.Clear();
            LuckList.Add(p);
            listBox1.Items.Add(p.inName);

            if (textBox3.Text == "")
                MessageBox.Show("이메일 미기입시 관련 소식을\r\n받아볼 수 없는점 유의 바랍니다.", "안내");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rand = new Random();

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
            int index = listBox1.SelectedIndex;

            Person p = (Person)LuckList[index];
            Lucktxt.Text = p.inLuck + ", " + p.inName + "(" + p.inGender + ")" + "의 운세는" 
                + "\r\n\r\n" + LuckArray[randomIndex];
        }
    }
    class Person
    {
        private string name;    
        private string gender;  
        private string luck;    

        public Person(string aName, string aGender, string aLuck)
        {
            name = aName;
            gender = aGender;
            luck = aLuck;
        }

        public string inName
        {
            set { name = value; }
            get { return name; }
        }
        public string inGender
        {
            set { gender = value; }
            get { return gender; }
        }
        public string inLuck
        {
            set { luck = value; }
            get { return luck; }
        }
    }
    class MyLuckList : ArrayList
    {
        public int AddPerson(string aName, string aGender, string aLuck)
        {
            return base.Add(new Person(aName, aGender, aLuck));
        }
    }
}
