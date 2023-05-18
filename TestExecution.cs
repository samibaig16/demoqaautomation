using demoqaproper.demoqaproper.Elements;
using demoqaproper.demoqaproper.Forms;
using demoqaproper.demoqaproper.Widgets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading;
using System.Data;
using demoqaproper.demoqaproper.AFW;
using System.Security.Policy;
using demoqaproper.demoqaproper.BookStoreApp;

namespace demoqaproper
{
    [TestClass]
    public class TestExecution
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }
        [ClassCleanup()]
        public static void ClassCleanup()
        {
        }
        [TestInitialize()]
        public void TestInit()
        {
            CorePage.SeleniumInit(ConfigurationManager.AppSettings["DeviceBrowser"].ToString());
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            CorePage.driver.Close();
        }
        TextBox textbox = new TextBox();
        CheckBox checkbox = new CheckBox();
        RadioButton radiobutton = new RadioButton();
        Buttons buttons = new Buttons();
        BrokenLinks brokenlinks = new BrokenLinks();
        Links links = new Links();
        Forms forms = new Forms();
        UandD uandd = new UandD();
        WebTables webtables = new WebTables();
        DynamicProperties dynamic = new DynamicProperties();
        BrowserWIndows afw = new BrowserWIndows();
        Alerts alerts = new Alerts();
        ModalDialogues modalogs = new ModalDialogues();
        Accordian accordian = new Accordian();
        AutoComplete atc = new AutoComplete();
        DatePicker datePicker = new DatePicker();
        Slider slider = new Slider();
        ProgressBar progressbar = new ProgressBar();
        Tabs tabs = new Tabs();
        ToolTips toolTips = new ToolTips();
        Menu menu = new Menu();
        SelectPage selectpage = new SelectPage();
        Sortable sortable = new Sortable();
        Select select = new Select();
        Resizable resizable = new Resizable();
        Droppable droppable = new Droppable();
        Draggable draggable = new Draggable();
        LoginandSignup login = new LoginandSignup();
        BookstorePage bookstore = new BookstorePage();
        APIPage apIPage = new APIPage();
        Frames frames = new Frames();
        NestedFrames nestedFrames = new NestedFrames();
        [TestCategory("TextBox")]
        [TestMethod]
        public void TextBox_TC001()
        {
            textbox.TextBoxMethod("https://demoqa.com/text-box", "Sami Baig", "samibaig21000@gmail.com", "JoharBlock2", "Nagan Chowrangi");
        }
        [TestCategory("CheckBox")]
        [TestMethod]
        public void CheckBoxTest_TC001()
        {
            checkbox.CheckBoxTest("https://demoqa.com/checkbox");
        }
        [TestMethod]
        [TestCategory("RadioButtonPage")]
        public void RadioButtonPage_TC001()
        {
            radiobutton.RadioButtonPage("https://demoqa.com/radio-button");
        }
        [TestCategory("WebTablesPage")]
        [TestMethod]
        public void WebTablesMethod_TC001()
        {
            webtables.WebTablesMethod("https://demoqa.com/webtables", "Sami", "Baig", "samibaig21000@gmail.com", "20", "200000", "BSCS");
        }
        [TestCategory("Buttons")]
        [TestMethod]
        public void ButtonPage_TC001()
        {
            buttons.ButtonsMethod("https://demoqa.com/buttons");

        }
        [TestCategory("Links")]
        [TestMethod]
        public void LinksMethod_TC001()
        {
            links.LinksMethodPage("https://demoqa.com/links");
        }
        [TestCategory("Links")]
        [TestMethod]
        public void LinksMethod_TC002()
        {
            links.LinksMethodPageMethodTwo("https://demoqa.com/links");
        }
        [TestCategory("Broken Links")]
        [TestMethod]
        public void BrokenValidLink_TC001()
        {
            brokenlinks.BrokenValidLink("https://demoqa.com/broken");
        }
        [TestCategory("Broken Links")]
        [TestMethod]
        public void BrokenLink_TC002()
        {
            brokenlinks.BrokenLink("https://demoqa.com/broken");
        }
        [TestCategory("ChooseFile")]
        [TestMethod]
        public void ChooseFile_TC001()
        {
            uandd.ChooseFile("https://demoqa.com/upload-download", "C:\\Users\\shahr\\Desktop\\rere.jpg");
        }
        [TestCategory("DynamicProperties")]
        [TestMethod]
        public void dynamicproperties_TC001()
        {
            dynamic.DynamicPropertiesTest("https://demoqa.com/dynamic-properties");
        }
        [TestCategory("Forms")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLFile1.xml", "Form_TC001", DataAccessMethod.Sequential)]
        public void Form_TC001()
        {
            string url = TestContext.DataRow["url"].ToString();
            string fname = TestContext.DataRow["fname"].ToString();
            string lname = TestContext.DataRow["lname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phonenumber = TestContext.DataRow["phonenumber"].ToString();
            string dob = TestContext.DataRow["dob"].ToString();
            string subject = TestContext.DataRow["Subject"].ToString();
            /*            string filePath = TestContext.DataRow["filelocation"].ToString();*/
            string currentaddres = TestContext.DataRow["currentaddress"].ToString();
            string state = TestContext.DataRow["state"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            forms.FormsEvaluation(url, fname, lname, email, phonenumber, dob, subject, "C:\\Users\\shahr\\Desktop\\rere.jpg", currentaddres, state, city);
        }
        [TestCategory("BrowserWindows")]
        [TestMethod]
        public void BrowserWindows_TC001()
        {
            afw.BrowserWindowsFirstButton("https://demoqa.com/browser-windows");
        }
        [TestCategory("BrowserWindows")]
        [TestMethod]
        public void BrowserWindows_TC002()
        {
            afw.BrowserWindowsSecondButton("https://demoqa.com/browser-windows");
        }
        [TestCategory("BrowserWindows")]
        [TestMethod]
        public void BrowserWindows_TC003()
        {
            afw.BrowserWindowsThirdButton("https://demoqa.com/browser-windows");
        }
        [TestCategory("Alert")]
        [TestMethod]
        public void Alerts_TC001()
        {
            alerts.AlertfirstButtonMethod("https://demoqa.com/alerts");
        }
        [TestCategory("Alert")]
        [TestMethod]
        public void Alerts_TC002()
        {
            alerts.AlertsecondButtonMethod("https://demoqa.com/alerts");
        }
        [TestCategory("Alert")]
        [TestMethod]
        public void Alerts_TC003()
        {
            alerts.AlertthirdButtonMethod("https://demoqa.com/alerts");
        }
        [TestCategory("Alert")]
        [TestMethod]
        public void Alerts_TC004()
        {
            alerts.AlertfourthButtonMethod("https://demoqa.com/alerts");
        }
        [TestCategory("ModelDialogues")]
        [TestMethod]
        public void ModalDialoguess_TC001()
        {
            modalogs.ModalDialoguessFirstButton("https://demoqa.com/modal-dialogs");
        }
        [TestCategory("ModelDialogues")]
        [TestMethod]
        public void ModalDialoguess_TC002()
        {
            modalogs.ModalDialoguessSecondButton("https://demoqa.com/modal-dialogs");
        }
        [TestCategory("Accordian")]
        [TestMethod]
        public void Accordians_TC001()
        {
            accordian.AccordianMethods("https://demoqa.com/accordian");
        }
        [TestCategory("Auto Complete")]
        [TestMethod]
        public void AutoComplete_TC001()
        {
            atc.AutoCompleteMultiple("https://demoqa.com/auto-complete");
        }
        [TestCategory("Auto Complete")]
        [TestMethod]
        public void AutoComplete_TC002()
        {
            atc.AutoCompleteSingle("https://demoqa.com/auto-complete");
        }
        [TestCategory("Date Picker")]
        [TestMethod]
        public void DatePicker_TC001()
        {
            datePicker.DatePickerFirstMethod("https://demoqa.com/date-picker");
        }
        [TestCategory("Date Picker")]
        [TestMethod]
        public void DatePicker_TC002()
        {
            datePicker.DatePickerSecondMethodd("https://demoqa.com/date-picker");
        }
        [TestCategory("SliderPage")]
        [TestMethod]
        public void Slider_TC001()
        {
            slider.SliderPage("https://demoqa.com/slider", "50");
        }
        [TestCategory("ProgessBar")]
        [TestMethod]
        public void ProgressBar_TC001()
        {
            progressbar.ProgressBarMethod("https://demoqa.com/progress-bar");
        }
        [TestCategory("TabsPage")]
        [TestMethod]
        public void TabsPage_TC001()
        {
            tabs.TabsPage("https://demoqa.com/tabs");
        }
        [TestCategory("ToolTipsPage")]
        [TestMethod]
        public void toolTips_TC001()
        {
            toolTips.tooltips("https://demoqa.com/tool-tips");

        }
        [TestCategory("MenuPage")]
        [TestMethod]
        public void MenuPage_TC001()
        {
            menu.MenuPageFirst("https://demoqa.com/menu");
            menu.MenuPageSecond("https://demoqa.com/menu");
            menu.MenuPageThird("https://demoqa.com/menu");
            menu.MenuPageFourth("https://demoqa.com/menu");
            menu.MenuPageFiveth("https://demoqa.com/menu");
            menu.MenuPageSixth("https://demoqa.com/menu");
        }
        [TestCategory("SelectPage")]
        [TestMethod]
        public void SelectPage_TC001()
        {
            selectpage.SelectValue("https://demoqa.com/select-menu");
            selectpage.SelectOne("https://demoqa.com/select-menu");
            selectpage.OldStyleSelectPage("https://demoqa.com/select-menu");
            selectpage.MultiSelectDropDownn("https://demoqa.com/select-menu");
            selectpage.StandardMultiSelect("https://demoqa.com/select-menu");
        }
        [TestCategory("Sortable")]
        [TestMethod]
        public void ListSortable_TC001()
        {
            sortable.List_Sortablee("https://demoqa.com/sortable");
        }
        [TestCategory("Sortable")]
        [TestMethod]
        public void GridSortable_TC002()
        {
            sortable.Grid_Sortablee("https://demoqa.com/sortable");
        }
        [TestCategory("Selectable")]
        [TestMethod]
        public void Selectable_TC001()
        {
            select.ListPageSelect("https://demoqa.com/selectable");
        }
        [TestCategory("Selectable")]
        [TestMethod]
        public void Selectable_TC002()
        {
            select.GridPageSelect("https://demoqa.com/selectable");
        }
        [TestCategory("Resizable")]
        [TestMethod]
        public void Resizable_TC001()
        {
            resizable.ResizablePage("https://demoqa.com/resizable");
           
        }
        [TestCategory("Droppable")]
        [TestMethod]
        public void Droppable_TC001()
        {
            droppable.SimpleBar("https://demoqa.com/droppable");
        }
        [TestCategory("Droppable")]
        [TestMethod]
        public void Droppable_TC002()
        {
            droppable.AcceptBar("https://demoqa.com/droppable");
        }
        [TestCategory("Droppable")]
        [TestMethod]
        public void Droppable_TC003()
        {
            droppable.PreventPropogation("https://demoqa.com/droppable");
        }
        [TestCategory("Droppable")]
        [TestMethod]
        public void Droppable_TC004()
        {
            droppable.RevertDraggAble("https://demoqa.com/droppable");
        }
        [TestCategory("Dragable")]
        [TestMethod]
        public void Dragable_TC001()
        {
/*            draggable.DraggablePage("https://demoqa.com/dragabble");
            draggable.AxisRestricted("https://demoqa.com/dragabble");*/
            draggable.Container_Restricted("https://demoqa.com/dragabble");
        }
        [TestCategory("BoookStore Signup and Login")]
        [TestMethod]
        public void LoginBooKStore_TC001()
        {
            login.Login_Bookstore("https://demoqa.com/login");
        }
        [TestCategory("BoookStore Signup and Login")]
        [TestMethod]
        public void SignupBookStore_TC001()
        {
            login.Signup_Bookstore("https://demoqa.com/register");
        }
        [TestCategory("ProfilePage")]
                [TestMethod]
        public void ProfilePage_TC001()
        {
            bookstore.ProfilePage_AddBookToYourCollection("https://demoqa.com/books");
        }
        [TestCategory("ProfilePage")]
        [TestMethod]
        public void ProfilePage_TC002()
        {
            bookstore.ClickonProfileandDeleteAllbooks("https://demoqa.com/login");
        }
        [TestCategory("ProfilePage")]
        [TestMethod]
        public void ProfilePage_TC003()
        {
            bookstore.DeleteAccountButton("https://demoqa.com/login");
        }
        [TestCategory("API TESTING PAGE")]
        [TestMethod]
        public void APITESTING_TC001()
        {
            apIPage.postapi_testing("https://demoqa.com/login");
        }
        [TestCategory("FRAMESPAGE")]
        [TestMethod]
        public void FRAMESPAGE_TC001()
        {
            frames.FramesPage("https://demoqa.com/frames");
        }
        [TestCategory("Nested Frames")]
        [TestMethod]
        public void nested_TC001()
        {
            nestedFrames.nested_frames("https://demoqa.com/nestedframes");
        }


    }

}
