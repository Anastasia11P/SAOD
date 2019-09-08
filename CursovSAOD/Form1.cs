using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CursovSAOD
{
    public partial class Form1 : Form
    {
        DoubleLinkedList ListShop;
        public Form1()
        {
            InitializeComponent();
        }

        void Update1() {
            listBoxShops.Items.Clear();
            foreach (StaticList list in ListShop.toListDoubleForward()) {
                listBoxShops.Items.Add(list);
            }
        }
        void Update2()
        {
            try
            {
                dataGridViewStaticList.DataSource = null;
                dataGridViewStaticList.DataSource = (listBoxShops.SelectedItem as StaticList).toList();
            }
            catch { }
        }
        void Update3()
        {
            listBoxShops.Items.Clear();
            foreach (StaticList list in ListShop.toListDoubleBackward())
            {
                listBoxShops.Items.Add(list);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxNameShop.Text))
            {
                if (ListShop.SearchForward(Int32.Parse(textBoxNameShop.Text)) == null)
                {
                    if ((int)sizeList.Value != 0)
                    {
                        StaticList workshop = new StaticList((int)sizeList.Value);
                        workshop.WorkshopName = Int32.Parse(textBoxNameShop.Text);
                        ListShop.Add(workshop);
                        textBoxNameShop.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Количество оборудования в цехе должно быть больше нуля");
                    }
                }
                else {
                    MessageBox.Show("Цех с таким номером уже существует");
                }
            }
            else
            {
                MessageBox.Show("Заполните поле Номер цеха");
            }
            if (radioButton1.Checked) {
                Update1();
            }
            if (radioButton2.Checked) {
                Update3();
            }  
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                StaticList list = (StaticList)listBoxShops.SelectedItem;
                ListShop.Remove(list);
                if (radioButton1.Checked)
                {
                    Update1();
                }
                if (radioButton2.Checked)
                {
                    Update3();
                }
                try
                {
                    dataGridViewStaticList.DataSource = null;
                }
                catch { }
            }
            catch(Exception err) {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void buttonAddStatic_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(textBoxNameEquipment.Text))
                {
                    if (listBoxShops.SelectedItem == null) throw new Exception("Не выбран цех");
                    if ((int)CountEquipment.Value != 0)
                    {
                        StaticList list = (StaticList)listBoxShops.SelectedItem;
                        if (list.Search(textBoxNameEquipment.Text) == null)
                        {
                            Equipment nEquipment = new Equipment(textBoxNameEquipment.Text, (int)CountEquipment.Value);
                            list.Add(nEquipment);
                        }
                        else {
                            MessageBox.Show("Оборудование с таким наименованием уже существует");
                        }
                        Update2();
                        textBoxNameEquipment.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Количество единиц оборудования в цехе должно быть больше нуля");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поле наименование оборудования");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteStatic_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxShops.SelectedItem != null && dataGridViewStaticList.CurrentRow != null)
                {
                    StaticList list = (StaticList)listBoxShops.SelectedItem;
                    list.Remove(dataGridViewStaticList.CurrentRow.Cells["Name"].Value.ToString());
                    Update2();
                }
                else
                {
                    MessageBox.Show("Удаляемое оборудование не выбрано");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update2();
        }

        private void textBoxNameShop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                XDocument doc = new XDocument();
                XElement enterprise = new XElement("Enterprise", new XAttribute("Name", this.Text));
                foreach (StaticList list in ListShop.toListDoubleForward())
                {
                    XElement workshop = new XElement("WorkShop",
                        new XAttribute("Number", list.WorkshopName),
                        new XAttribute("Size", list.Size));
                    foreach (Equipment equipment in list.toList())
                    {
                        XElement nEquipment = new XElement("Equipment",
                        new XAttribute("NameEquipment", equipment.Name),
                        new XAttribute("CountEquipment", equipment.Count));
                        workshop.Add(nEquipment);
                    }
                    enterprise.Add(workshop);
                }

                doc.Add(enterprise);
                doc.Save(saveFile.FileName);
                MessageBox.Show("База сохранена.");
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ListShop != null)
            {
                DialogResult result = MessageBox.Show("Все несохраненные данные будут утеряны после открытия нового файла. Продолжить?", "Открытие файла", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ListShop.Dispose_();
                }
                else
                {
                    return;
                }
            }
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    XDocument doc = XDocument.Load(openFile.FileName);
                    if (doc.Declaration.Encoding.Equals("utf-8") || doc.Declaration.Encoding.Equals("UTF-8"))
                    {

                        groupBox1.Enabled = true;
                        сохранитьToolStripMenuItem.Enabled = true;

                        XElement enterprise = doc.Root;
                        ListShop = new DoubleLinkedList();
                        this.Text = enterprise.Attribute("Name").Value;
                        if (enterprise.HasElements)
                        {
                            foreach (XElement xWorkShop in enterprise.Elements())
                            {
                                if ((ListShop.SearchForward(Int32.Parse(xWorkShop.Attribute("Number").Value)) == null) && (!String.IsNullOrWhiteSpace(xWorkShop.Attribute("Number").Value)) && (!String.IsNullOrWhiteSpace(xWorkShop.Attribute("Size").Value)) && (Int32.Parse(xWorkShop.Attribute("Size").Value) != 0))
                                {
                                    StaticList workshop = new StaticList(Int32.Parse(xWorkShop.Attribute("Size").Value));
                                    workshop.WorkshopName = Int32.Parse(xWorkShop.Attribute("Number").Value);
                                    if (xWorkShop.HasElements)
                                    {
                                        foreach (XElement xEquipment in xWorkShop.Elements())
                                        {
                                            if ((workshop.Search(xEquipment.Attribute("NameEquipment").Value) == null) && (!String.IsNullOrWhiteSpace(xEquipment.Attribute("NameEquipment").Value.ToString())) && (!String.IsNullOrWhiteSpace(xEquipment.Attribute("CountEquipment").Value)) && (Int32.Parse(xEquipment.Attribute("CountEquipment").Value) != 0))
                                            {
                                                Equipment equipment = new Equipment(xEquipment.Attribute("NameEquipment").Value, Int32.Parse(xEquipment.Attribute("CountEquipment").Value));
                                                workshop.Add(equipment);
                                            }
                                            else
                                            {
                                                ListShop.Dispose_();
                                                ListShop = null;
                                                GC.Collect();
                                                groupBox1.Enabled = false;
                                                сохранитьToolStripMenuItem.Enabled = false;
                                                this.Text = "";
                                                MessageBox.Show("Загружаемая база повреждена");
                                                return;
                                            }
                                        }
                                    }
                                    ListShop.Add(workshop);
                                }
                                else
                                {
                                    ListShop.Dispose_();
                                    ListShop = null;
                                    GC.Collect();
                                    groupBox1.Enabled = false;
                                    сохранитьToolStripMenuItem.Enabled = false;
                                    this.Text = "";
                                    MessageBox.Show("Загружаемая база повреждена");
                                    return;
                                }
                            }
                        }
                        if (radioButton1.Checked)
                        {
                            Update1();
                        }
                        if (radioButton2.Checked)
                        {
                            Update3();
                        }
                        try
                        {
                            dataGridViewStaticList.DataSource = null;
                        }
                        catch { }
                    }
                    else {
                        MessageBox.Show("Загружаемая база повреждена");
                    } 
                }
            }
            catch
            {
                groupBox1.Enabled = false;
                сохранитьToolStripMenuItem.Enabled = false;
                if (ListShop != null) {
                    ListShop.Dispose_();
                    ListShop = null;
                    GC.Collect();
                }
                MessageBox.Show("Загружаемая база повреждена");
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Введите наименование предприятия", "Создание предприятия", "");
            if (!String.IsNullOrWhiteSpace(name))
            {
                if (ListShop != null)
                {
                    DialogResult result = MessageBox.Show("Все несохраненные данные будут утеряны после создания нового предприятия. Продолжить?", "Создание нового предприятия", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        ListShop.Dispose_();
                    }
                    else
                    {
                        return;
                    }
                }
                this.Text = name;
                groupBox1.Enabled = true;
                сохранитьToolStripMenuItem.Enabled = true;
                listBoxShops.Items.Clear();
                try
                {
                    dataGridViewStaticList.DataSource = null;
                }
                catch { }
                ListShop = new DoubleLinkedList();
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа на тему:\nДинамический упорядоченный двунаправленный список упорядоченных статических списков\nВыполнила: студентка группы 4216 Паняева А.С.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchShop_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxNameShopSearch.Text))
            {
                int nameShop = Int32.Parse(textBoxNameShopSearch.Text);
                if (radioButton1.Checked) {
                    Node resultSearch = ListShop.SearchForward(nameShop);
                    if (resultSearch != null)
                    {
                        MessageBox.Show("Цех " + resultSearch.Shop.WorkshopName + " найден (поиск в прямом направлении)");
                    }
                    else {
                        MessageBox.Show("Цех " + nameShop.ToString() + " не найден (поиск в прямом направлении)");
                    }
                }
                if (radioButton2.Checked)
                {
                    Node resultSearch = ListShop.SearchBackward(nameShop);
                    if (resultSearch != null)
                    {
                        MessageBox.Show("Цех " + resultSearch.Shop.WorkshopName + " найден (поиск в обратном направлении)");
                    }
                    else
                    {
                        MessageBox.Show("Цех " + nameShop.ToString() + " не найден (поиск в обратном направлении)");
                    }
                }
                textBoxNameShopSearch.Text = "";
            }
        }

        private void buttonSearchEquipment_Click(object sender, EventArgs e)
        {
            try {
                if (!String.IsNullOrWhiteSpace(textBoxNameEquipmentSearch.Text))
                {
                    if (listBoxShops.SelectedItem == null) throw new Exception("Не выбран цех");
                    if (listBoxShops.SelectedItem != null)
                    {
                        StaticList list = (StaticList)listBoxShops.SelectedItem;
                        string nameEquipment = textBoxNameEquipmentSearch.Text;
                        Equipment result = list.Search(nameEquipment);
                        if (result!= null)
                        {
                            MessageBox.Show("Оборудование " + result.Name + " найдено количество " + result.Count.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Оборудование " + nameEquipment + " не найдено");
                        }
                        textBoxNameEquipmentSearch.Text = "";
                    }
                }
                else { Update2(); }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxNameEquipment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ListShop != null)
            {
                DialogResult result = MessageBox.Show("Все несохраненные данные будут утеряны после закрытия окна. Продолжить?", "Завершение работы", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    e.Cancel = false;
                    if (ListShop != null)
                    {
                        ListShop.Dispose_();
                        ListShop = null;
                        GC.Collect();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else {
                e.Cancel = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Update1();
            try
            {
                dataGridViewStaticList.DataSource = null;
            }
            catch { }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Update3();
            try
            {
                dataGridViewStaticList.DataSource = null;
            }
            catch { }
        }
    }
}
