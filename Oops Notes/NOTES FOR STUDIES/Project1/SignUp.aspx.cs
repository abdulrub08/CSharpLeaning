using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using System.Net;


public partial class SignUp : System.Web.UI.Page
{
    MyConnectionString css = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlcity.Items.Clear();
        switch (ddlstate.SelectedIndex)
        {
            //1-Andaman and Nicobar Islands
            case 1:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Port Blair*");
                break;


            //2-Andhra Pradesh
            case 2:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Anantapur");
                ddlcity.Items.Add("Anakapalle");
                ddlcity.Items.Add("Amalapuram");
                ddlcity.Items.Add("Amadalavalasa");
                ddlcity.Items.Add("Adoni");
                ddlcity.Items.Add("Adilabad");
                ddlcity.Items.Add("Badepalle");
                ddlcity.Items.Add("Banganapalle");
                ddlcity.Items.Add("Bapatla");
                ddlcity.Items.Add("Bellampalle");
                ddlcity.Items.Add("Bhadrachalam");
                ddlcity.Items.Add("Bhongir");
                ddlcity.Items.Add("Chilakaluripet");
                ddlcity.Items.Add("Chirala");
                ddlcity.Items.Add("Chittoor");
                ddlcity.Items.Add("Devarakonda");
                ddlcity.Items.Add("Dharmavaram");
                ddlcity.Items.Add("Eluru");
                ddlcity.Items.Add("Farooqnagar");
                ddlcity.Items.Add("Gadwal");
                ddlcity.Items.Add("Gooty");
                ddlcity.Items.Add("Gudivada");
                ddlcity.Items.Add("Gudur");
                ddlcity.Items.Add("Guntakal");
                ddlcity.Items.Add("Guntur");
                ddlcity.Items.Add("Hanuman Junction");
                ddlcity.Items.Add("Hindupur");
                ddlcity.Items.Add("Hyderabad*");
                ddlcity.Items.Add("Ichchapuram");
                ddlcity.Items.Add("Itanagar");
                ddlcity.Items.Add("Jaggaiahpet");
                ddlcity.Items.Add("Jagtial");
                ddlcity.Items.Add("Jammalamadugu");
                ddlcity.Items.Add("Jangaon");
                ddlcity.Items.Add("Kadapa");
                ddlcity.Items.Add("Kadiri");
                ddlcity.Items.Add("Kagaznagar");
                ddlcity.Items.Add("Kakinada");
                ddlcity.Items.Add("Kalyandurg");
                ddlcity.Items.Add("Kamareddy");
                ddlcity.Items.Add("Kandukur");
                ddlcity.Items.Add("Karimnagar");
                ddlcity.Items.Add("Kavali");
                ddlcity.Items.Add("Khammam");
                ddlcity.Items.Add("Koratla");
                ddlcity.Items.Add("Kothagudem");
                ddlcity.Items.Add("Kothapeta");
                ddlcity.Items.Add("Kovvur");
                ddlcity.Items.Add("Kurnool");
                ddlcity.Items.Add("Kyathampalle");
                ddlcity.Items.Add("Macherla");
                ddlcity.Items.Add("Machilipatnam");
                ddlcity.Items.Add("Madanapalle");
                ddlcity.Items.Add("Mahbubnagar");
                ddlcity.Items.Add("Mandamarri");
                ddlcity.Items.Add("Mandapeta");
                ddlcity.Items.Add("Manuguru");
                ddlcity.Items.Add("Markapur");
                ddlcity.Items.Add("Medak");
                ddlcity.Items.Add("Miryalaguda");
                ddlcity.Items.Add("Mogalthur");
                ddlcity.Items.Add("Nagari");
                ddlcity.Items.Add("Nagarkurnool");
                ddlcity.Items.Add("Nandyal");
                ddlcity.Items.Add("Narasapur");
                ddlcity.Items.Add("Narasaraopet");
                ddlcity.Items.Add("Narsipatnam");
                ddlcity.Items.Add("Nellore");
                ddlcity.Items.Add("Nidadavole");
                ddlcity.Items.Add("Nirmal");
                ddlcity.Items.Add("Nizamabad");
                ddlcity.Items.Add("Nuzvid");
                ddlcity.Items.Add("Ongole");
                ddlcity.Items.Add("Palacole");
                ddlcity.Items.Add("Palasa Kasibugga");
                ddlcity.Items.Add("Palwancha");
                ddlcity.Items.Add("Parvathipuram");
                ddlcity.Items.Add("Pedana");
                ddlcity.Items.Add("Peddapuram");
                ddlcity.Items.Add("Pithapuram");
                ddlcity.Items.Add("Ponnur");
                ddlcity.Items.Add("Proddatur");
                ddlcity.Items.Add("Punganur");
                ddlcity.Items.Add("Puttur");
                ddlcity.Items.Add("Rajahmundry");
                ddlcity.Items.Add("Rajam");
                ddlcity.Items.Add("Ramachandrapuram");
                ddlcity.Items.Add("Ramagundam");
                ddlcity.Items.Add("Rayachoti");
                ddlcity.Items.Add("Rayadurg");
                ddlcity.Items.Add("Renigunta");
                ddlcity.Items.Add("Repalle");
                ddlcity.Items.Add("Sadasivpet");
                ddlcity.Items.Add("Salur");
                ddlcity.Items.Add("Samalkot");
                ddlcity.Items.Add("Sangareddy");
                ddlcity.Items.Add("Sattenapalle");
                ddlcity.Items.Add("Secundrabad");
                ddlcity.Items.Add("Siddipet");
                ddlcity.Items.Add("Singapur");
                ddlcity.Items.Add("Sircilla");
                ddlcity.Items.Add("Srikakulam");
                ddlcity.Items.Add("Srikalahasti");
                ddlcity.Items.Add("Srisailam Project Township");
                ddlcity.Items.Add("Suryapet");
                ddlcity.Items.Add("Tadepalligudem");
                ddlcity.Items.Add("Tadpatri");
                ddlcity.Items.Add("Tandur");
                ddlcity.Items.Add("Tanuku");
                ddlcity.Items.Add("Tenali");
                ddlcity.Items.Add("Tirupati");
                ddlcity.Items.Add("Tuni");
                ddlcity.Items.Add("Uravakonda");
                ddlcity.Items.Add("Venkatagiri");
                ddlcity.Items.Add("Vicarabad");
                ddlcity.Items.Add("Vijayawada");
                ddlcity.Items.Add("Vinukonda");
                ddlcity.Items.Add("Visakhapatnam");
                ddlcity.Items.Add("Vizianagaram");
                ddlcity.Items.Add("Wanaparthy");
                ddlcity.Items.Add("Warangal");
                ddlcity.Items.Add("Yellandu");
                ddlcity.Items.Add("Yemmiganur");
                ddlcity.Items.Add("Yerraguntla");
                ddlcity.Items.Add("Zahirabad");
                ddlcity.Items.Add("Adilabad");
                ddlcity.Items.Add("Badepalle");
                ddlcity.Items.Add("Banganapalle");
                ddlcity.Items.Add("Bapatla");
                ddlcity.Items.Add("Bellampalle");
                ddlcity.Items.Add("Bhadrachalam");
                ddlcity.Items.Add("Bhongir");
                ddlcity.Items.Add("Chilakaluripet");
                ddlcity.Items.Add("Chirala");
                break;


            //3-Arunachal Pradesh
            case 3:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Bomdila");
                ddlcity.Items.Add("Itanagar*");
                ddlcity.Items.Add("Pasighat");
                ddlcity.Items.Add("Varanashi");
                break;


            //4-Assam
            case 4:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Barpeta");
                ddlcity.Items.Add("Barpeta Road");
                ddlcity.Items.Add("Bilasipara");
                ddlcity.Items.Add("Bongaigaon");
                ddlcity.Items.Add("Dhekiajuli");
                ddlcity.Items.Add("Dhubri");
                ddlcity.Items.Add("Dibrugarh");
                ddlcity.Items.Add("Digboi");
                ddlcity.Items.Add("Diphu");
                ddlcity.Items.Add("Dispur*");
                ddlcity.Items.Add("Duliajan Oil Town");
                ddlcity.Items.Add("Gauripur");
                ddlcity.Items.Add("Goalpara");
                ddlcity.Items.Add("Golaghat");
                ddlcity.Items.Add("Guwahati");
                ddlcity.Items.Add("Haflong");
                ddlcity.Items.Add("Hailakandi");
                ddlcity.Items.Add("Hojai");
                ddlcity.Items.Add("Jorhat");
                ddlcity.Items.Add("Karimganj");
                ddlcity.Items.Add("Kokrajhar");
                ddlcity.Items.Add("Lanka");
                ddlcity.Items.Add("Lumding");
                ddlcity.Items.Add("Mangaldoi");
                ddlcity.Items.Add("Mankachar");
                ddlcity.Items.Add("Margherita");
                ddlcity.Items.Add("Mariani");
                ddlcity.Items.Add("Marigaon");
                ddlcity.Items.Add("Nagaon");
                ddlcity.Items.Add("Nalbari");
                ddlcity.Items.Add("North Lakhimpur");
                ddlcity.Items.Add("Rangia");
                ddlcity.Items.Add("Sibsagar");
                ddlcity.Items.Add("Silapathar");
                ddlcity.Items.Add("Silchar");
                ddlcity.Items.Add("Sibsagar");
                ddlcity.Items.Add("Tezpur");
                ddlcity.Items.Add("Tinsukia");
                break;


            //5-Bihar
            case 5:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Amarpur");
                ddlcity.Items.Add("Araria");
                ddlcity.Items.Add("Areraj");
                ddlcity.Items.Add("Arrah");
                ddlcity.Items.Add("Aurangabad");
                ddlcity.Items.Add("Bagaha");
                ddlcity.Items.Add("Bahadurganj");
                ddlcity.Items.Add("Bairgania");
                ddlcity.Items.Add("Bakhtiarpur");
                ddlcity.Items.Add("Banka");
                ddlcity.Items.Add("Banmankhi Baza");
                ddlcity.Items.Add("Barahiya");
                ddlcity.Items.Add("Barauli");
                ddlcity.Items.Add("Barbigha");
                ddlcity.Items.Add("Barh");
                ddlcity.Items.Add("Begusarai");
                ddlcity.Items.Add("Behea");
                ddlcity.Items.Add("Bettiah");
                ddlcity.Items.Add("Bhabua");
                ddlcity.Items.Add("Bhagalpur");
                ddlcity.Items.Add("Bihar");
                ddlcity.Items.Add("Bikramganj");
                ddlcity.Items.Add("Bodh Gaya");
                ddlcity.Items.Add("Buxar");
                ddlcity.Items.Add("Chanpatia");
                ddlcity.Items.Add("Chhapra");
                ddlcity.Items.Add("Colgong");
                ddlcity.Items.Add("Dalsinghsarai");
                ddlcity.Items.Add("Darbhanga");
                ddlcity.Items.Add("Daudnagar");
                ddlcity.Items.Add("Dehri-on-Sone");
                ddlcity.Items.Add("Dhaka");
                ddlcity.Items.Add("Dighwara");
                ddlcity.Items.Add("Dudhara");
                ddlcity.Items.Add("Dumraon");
                ddlcity.Items.Add("Fatwah");
                ddlcity.Items.Add("Forbesganj");
                ddlcity.Items.Add("Gaya");
                ddlcity.Items.Add("Gogri Jamalpu");
                ddlcity.Items.Add("Gopalganj");
                ddlcity.Items.Add("Hajipur");
                ddlcity.Items.Add("Hilsa");
                ddlcity.Items.Add("Hisua");
                ddlcity.Items.Add("Islampur");
                ddlcity.Items.Add("Jagdishpur");
                ddlcity.Items.Add("Jamalpur");
                ddlcity.Items.Add("Jamui");
                ddlcity.Items.Add("Jehanabad");
                ddlcity.Items.Add("Jhajha");
                ddlcity.Items.Add("Jhanjharpur");
                ddlcity.Items.Add("Jogabani");
                ddlcity.Items.Add("Kanti");
                ddlcity.Items.Add("Katihar");
                ddlcity.Items.Add("Khagaria");
                ddlcity.Items.Add("Kharagpur");
                ddlcity.Items.Add("Kishanganj");
                ddlcity.Items.Add("Lakhisarai");
                ddlcity.Items.Add("Lalganj");
                ddlcity.Items.Add("Madhepura");
                ddlcity.Items.Add("Madhubani");
                ddlcity.Items.Add("Maharajganj");
                ddlcity.Items.Add("Mahnar Bazar");
                ddlcity.Items.Add("Makhdumpur");
                ddlcity.Items.Add("Maner");
                ddlcity.Items.Add("Manihari");
                ddlcity.Items.Add("Marhaura");
                ddlcity.Items.Add("Masaurhi");
                ddlcity.Items.Add("Mirganj");
                ddlcity.Items.Add("Mokameh");
                ddlcity.Items.Add("Motihari");
                ddlcity.Items.Add("Motipur");
                ddlcity.Items.Add("Munger");
                ddlcity.Items.Add("Murliganj");
                ddlcity.Items.Add("Muzaffarpur");
                ddlcity.Items.Add("Narkatiaganj");
                ddlcity.Items.Add("Naugachhia");
                ddlcity.Items.Add("Nawada");
                ddlcity.Items.Add("Nokha");
                ddlcity.Items.Add("Patna*");
                ddlcity.Items.Add("Piro");
                ddlcity.Items.Add("Purnia");
                ddlcity.Items.Add("Rafiganj");
                ddlcity.Items.Add("Rajgir");
                ddlcity.Items.Add("Ramnagar");
                ddlcity.Items.Add("Raxaul Bazar");
                ddlcity.Items.Add("Revelganj");
                ddlcity.Items.Add("Rosera");
                ddlcity.Items.Add("Saharsa");
                ddlcity.Items.Add("Samastipur");
                ddlcity.Items.Add("Sasaram");
                ddlcity.Items.Add("Sheikhpura");
                ddlcity.Items.Add("Sheohar");
                ddlcity.Items.Add("Sherghati");
                ddlcity.Items.Add("Silao");
                ddlcity.Items.Add("Sitamarhi");
                ddlcity.Items.Add("Siwan");
                ddlcity.Items.Add("Sonepur");
                ddlcity.Items.Add("Sugauli");
                ddlcity.Items.Add("Sultanganj");
                ddlcity.Items.Add("Supaul");
                ddlcity.Items.Add("Warisaliganj");
                break;
            //6-Chandigarh
            case 6:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Chandigarh*");
                break;


            //7-Chhattisgarh
            case 7:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Akaltara");
                ddlcity.Items.Add("Ambikapur");
                ddlcity.Items.Add("Bade Bacheli");
                ddlcity.Items.Add("Balod");
                ddlcity.Items.Add("Baloda Bazar");
                ddlcity.Items.Add("Bemetra");
                ddlcity.Items.Add("Bhatapara");
                ddlcity.Items.Add("Bilaspur");
                ddlcity.Items.Add("Birgaon");
                ddlcity.Items.Add("Champa");
                ddlcity.Items.Add("Chirmiri");
                ddlcity.Items.Add("Dalli-Rajhara");
                ddlcity.Items.Add("Dhamtari");
                ddlcity.Items.Add("Dipka");
                ddlcity.Items.Add("Dongargarh");
                ddlcity.Items.Add("Durg-Bhilai Nagar");
                ddlcity.Items.Add("Gobranawapara");
                ddlcity.Items.Add("Jagdalpur");
                ddlcity.Items.Add("Jashpurnagar");
                ddlcity.Items.Add("Kanker");
                ddlcity.Items.Add("Kawardha");
                ddlcity.Items.Add("Kondagaon");
                ddlcity.Items.Add("Korba");
                ddlcity.Items.Add("Mahasamund");
                ddlcity.Items.Add("Mahendragarh");
                ddlcity.Items.Add("Mungeli");
                ddlcity.Items.Add("Naila Janjgir");
                ddlcity.Items.Add("Raigarh");
                ddlcity.Items.Add("Raipur*");
                ddlcity.Items.Add("Rajnandgaon");
                ddlcity.Items.Add("Sakti");
                ddlcity.Items.Add("Tilda Newra");
                break;


            //8-Dadra & Nagar Haveli
            case 8:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Amli");
                ddlcity.Items.Add("Silvassa*");
                break;


            //9-Daman & Diu
            case 9:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Daman*");
                ddlcity.Items.Add("Diu");
                break;


            //10-Delhi
            case 10:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Delhi*");
                break;


            //11-Goa
            case 11:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Curchorem Cacora");
                ddlcity.Items.Add("Madgaon");
                ddlcity.Items.Add("Mapusa");
                ddlcity.Items.Add("Margao");
                ddlcity.Items.Add("Marmagao");
                ddlcity.Items.Add("Panaji*");
                break;


            //12-Gujarat
            case 12:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Adipur");
                ddlcity.Items.Add("Ahmedabad");
                ddlcity.Items.Add("Amreli");
                ddlcity.Items.Add("Anand");
                ddlcity.Items.Add("Ankleshwar");
                ddlcity.Items.Add("Bharuch");
                ddlcity.Items.Add("Bhavnagar");
                ddlcity.Items.Add("Bhuj");
                ddlcity.Items.Add("Cambay");
                ddlcity.Items.Add("Dahod");
                ddlcity.Items.Add("Deesa");
                ddlcity.Items.Add("Dharampur");
                ddlcity.Items.Add("Dholka");
                ddlcity.Items.Add("Gandhinagar*");
                ddlcity.Items.Add("Godhra");
                ddlcity.Items.Add("Himatnagar");
                ddlcity.Items.Add("Idar");
                ddlcity.Items.Add("Jamnagar");
                ddlcity.Items.Add("Junagadh");
                ddlcity.Items.Add("Kadi");
                ddlcity.Items.Add("Kalavad");
                ddlcity.Items.Add("Kalol");
                ddlcity.Items.Add("Kalol");
                ddlcity.Items.Add("Kapadvanj");
                ddlcity.Items.Add("Karjan");
                ddlcity.Items.Add("Keshod");
                ddlcity.Items.Add("Khambhalia");
                ddlcity.Items.Add("Kheda");
                ddlcity.Items.Add("Khedbrahma");
                ddlcity.Items.Add("Kheralu");
                ddlcity.Items.Add("Kodinar");
                ddlcity.Items.Add("Lathi");
                ddlcity.Items.Add("Limbdi");
                ddlcity.Items.Add("Lunawada");
                ddlcity.Items.Add("Mahesana");
                ddlcity.Items.Add("Mahuva");
                ddlcity.Items.Add("Manavadar");
                ddlcity.Items.Add("Mandvi");
                ddlcity.Items.Add("Mangrol");
                ddlcity.Items.Add("Mansa");
                ddlcity.Items.Add("Mehmedabad");
                ddlcity.Items.Add("Modasa");
                ddlcity.Items.Add("Morvi");
                ddlcity.Items.Add("Nadiad");
                ddlcity.Items.Add("Navsari");
                ddlcity.Items.Add("Padra");
                ddlcity.Items.Add("Palanpur");
                ddlcity.Items.Add("Palitana");
                ddlcity.Items.Add("Pardi");
                ddlcity.Items.Add("Patan");
                ddlcity.Items.Add("Petlad");
                ddlcity.Items.Add("Porbandar");
                ddlcity.Items.Add("Radhanpur");
                ddlcity.Items.Add("Rajkotr");
                ddlcity.Items.Add("Rajpipla");
                ddlcity.Items.Add("Rajula");
                ddlcity.Items.Add("Ranavav");
                ddlcity.Items.Add("Rapar");
                ddlcity.Items.Add("Salaya");
                ddlcity.Items.Add("Sanand");
                ddlcity.Items.Add("Savarkundla");
                ddlcity.Items.Add("Sidhpur");
                ddlcity.Items.Add("Sihor");
                ddlcity.Items.Add("Songadh");
                ddlcity.Items.Add("Songadh");
                ddlcity.Items.Add("Surendranagar");
                ddlcity.Items.Add("Talaja");
                ddlcity.Items.Add("Thangadh");
                ddlcity.Items.Add("Tharad");
                ddlcity.Items.Add("Umbergaon");
                ddlcity.Items.Add("Umreth");
                ddlcity.Items.Add("Una");
                ddlcity.Items.Add("Unjha");
                ddlcity.Items.Add("Upleta");
                ddlcity.Items.Add("Vadnagar");
                ddlcity.Items.Add("Vadodara");
                ddlcity.Items.Add("Valsad");
                ddlcity.Items.Add("Vapi city");
                ddlcity.Items.Add("Veraval");
                ddlcity.Items.Add("Vijapur");
                ddlcity.Items.Add("Viramgam");
                ddlcity.Items.Add("Visnagar");
                ddlcity.Items.Add("Vyara");
                ddlcity.Items.Add("Wadhwan");
                ddlcity.Items.Add("Wankaner");
                break;


            //13-Haryana
            case 13:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Ambala");
                ddlcity.Items.Add("Assandh");
                ddlcity.Items.Add("Babiyal");
                ddlcity.Items.Add("Bahadurgarh");
                ddlcity.Items.Add("Barwala");
                ddlcity.Items.Add("Bhiwani");
                ddlcity.Items.Add("Charkhi Dadri");
                ddlcity.Items.Add("Chandigarh*");
                ddlcity.Items.Add("Cheeka");
                ddlcity.Items.Add("Ellenabad");
                ddlcity.Items.Add("Faridabad");
                ddlcity.Items.Add("Fatehabad");
                ddlcity.Items.Add("Ganaur");
                ddlcity.Items.Add("Gharaunda");
                ddlcity.Items.Add("Gohana");
                ddlcity.Items.Add("Gurgaon");
                ddlcity.Items.Add("Hansi");
                ddlcity.Items.Add("Hisar");
                ddlcity.Items.Add("Hodal");
                ddlcity.Items.Add("Jhajjar");
                ddlcity.Items.Add("Jind");
                ddlcity.Items.Add("Kaithal");
                ddlcity.Items.Add("Kalan Wali");
                ddlcity.Items.Add("Kalka");
                ddlcity.Items.Add("Karnal");
                ddlcity.Items.Add("Ladwa");
                ddlcity.Items.Add("Mahendragarh");
                ddlcity.Items.Add("Mandi Dabwali");
                ddlcity.Items.Add("Narnaul");
                ddlcity.Items.Add("Narwana");
                ddlcity.Items.Add("Palwal");
                ddlcity.Items.Add("Panchkula");
                ddlcity.Items.Add("Panipat");
                ddlcity.Items.Add("Pehowa");
                ddlcity.Items.Add("Pinjore");
                ddlcity.Items.Add("Rania");
                ddlcity.Items.Add("Ratia");
                ddlcity.Items.Add("Rewari");
                ddlcity.Items.Add("Rohtak");
                ddlcity.Items.Add("Rohtak");
                ddlcity.Items.Add("Samalkha");
                ddlcity.Items.Add("Shahbad");
                ddlcity.Items.Add("Sirsa");
                ddlcity.Items.Add("Sohna");
                ddlcity.Items.Add("Sonipat");
                ddlcity.Items.Add("Taraori");
                ddlcity.Items.Add("Thanesar");
                ddlcity.Items.Add("Tohana");
                ddlcity.Items.Add("Yamunanagar");
                break;

            //14-Himanchal Pradesh
            case 14:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Shimla*");
                break;



            //15-Jammu and Kashmir
            case 15:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Anantnag");
                ddlcity.Items.Add("Bandipore");
                ddlcity.Items.Add("Baramula");
                ddlcity.Items.Add("Jammu");
                ddlcity.Items.Add("Kathua");
                ddlcity.Items.Add("Leh");
                ddlcity.Items.Add("Punch");
                ddlcity.Items.Add("Rajauri");
                ddlcity.Items.Add("Sopore");
                ddlcity.Items.Add("Srinagar*");
                ddlcity.Items.Add("Udhampur");
                break;


            //16-Jharkhand
            case 16:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Barughutu");
                ddlcity.Items.Add("Bokaro Steel City");
                ddlcity.Items.Add("Chaibasa");
                ddlcity.Items.Add("Chakradharpur");
                ddlcity.Items.Add("Chandrapura");
                ddlcity.Items.Add("Chatra");
                ddlcity.Items.Add("Chirkunda");
                ddlcity.Items.Add("Churi");
                ddlcity.Items.Add("Daltonganj");
                ddlcity.Items.Add("Deoghar");
                ddlcity.Items.Add("Dhanbad");
                ddlcity.Items.Add("Dumka");
                ddlcity.Items.Add("Garhwa");
                ddlcity.Items.Add("Ghatshila");
                ddlcity.Items.Add("Giridih");
                ddlcity.Items.Add("Godda");
                ddlcity.Items.Add("Gomoh");
                ddlcity.Items.Add("Gumia");
                ddlcity.Items.Add("Gumla");
                ddlcity.Items.Add("Hazaribag");
                ddlcity.Items.Add("Hussainabad");
                ddlcity.Items.Add("Jamshedpur");
                ddlcity.Items.Add("Jamtara");
                ddlcity.Items.Add("Jhumri Tilaiya");
                ddlcity.Items.Add("Khunti");
                ddlcity.Items.Add("Lohardaga");
                ddlcity.Items.Add("Madhupur");
                ddlcity.Items.Add("Mihijam");
                ddlcity.Items.Add("Musabani");
                ddlcity.Items.Add("Pakaur");
                ddlcity.Items.Add("Patratu");
                ddlcity.Items.Add("Phusro");
                ddlcity.Items.Add("Ramngarh");
                ddlcity.Items.Add("Ranchi*");
                ddlcity.Items.Add("Sahibganj");
                ddlcity.Items.Add("Saunda");
                ddlcity.Items.Add("Simdega");
                ddlcity.Items.Add("Tenu Dam-cum- Kathhara");
                break;


            //17-Karnataka
            case 17:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Arasikere");
                ddlcity.Items.Add("Belgaum");
                ddlcity.Items.Add("Bellary");
                ddlcity.Items.Add("Bangalore*");
                ddlcity.Items.Add("Chamrajnagar");
                ddlcity.Items.Add("Chintamani");
                ddlcity.Items.Add("Chitradurga");
                ddlcity.Items.Add("Gulbarga");
                ddlcity.Items.Add("Gundlupet");
                ddlcity.Items.Add("Hassan");
                ddlcity.Items.Add("Hospet");
                ddlcity.Items.Add("Hubli");
                ddlcity.Items.Add("Karkala");
                ddlcity.Items.Add("Karwar");
                ddlcity.Items.Add("Kolar");
                ddlcity.Items.Add("Kota");
                ddlcity.Items.Add("Lakshmeshwar");
                ddlcity.Items.Add("Lingsugur");
                ddlcity.Items.Add("Madikeri");
                ddlcity.Items.Add("Mandya");
                ddlcity.Items.Add("Mangalore");
                ddlcity.Items.Add("Mysore");
                ddlcity.Items.Add("Nanjangud");
                ddlcity.Items.Add("Ramanagara");
                ddlcity.Items.Add("Sadalgi");
                ddlcity.Items.Add("Sagara");
                ddlcity.Items.Add("Sakleshpur");
                ddlcity.Items.Add("Sandur");
                ddlcity.Items.Add("Sankeshwar");
                ddlcity.Items.Add("Saundatti-Yellamma");
                ddlcity.Items.Add("Savanur");
                ddlcity.Items.Add("Sedam");
                ddlcity.Items.Add("Shahabad");
                ddlcity.Items.Add("Shahpur");
                ddlcity.Items.Add("Shiggaon");
                ddlcity.Items.Add("Shikapur");
                ddlcity.Items.Add("Shimoga");
                ddlcity.Items.Add("Shimoga");
                ddlcity.Items.Add("Shorapur");
                ddlcity.Items.Add("Shrirangapattana");
                ddlcity.Items.Add("Sidlaghatta");
                ddlcity.Items.Add("Sindgi");
                ddlcity.Items.Add("Sindhnur");
                ddlcity.Items.Add("Sira");
                ddlcity.Items.Add("Sirsi");
                ddlcity.Items.Add("Siruguppa");
                ddlcity.Items.Add("Srinivaspur");
                ddlcity.Items.Add("Talikota");
                ddlcity.Items.Add("Tarikere");
                ddlcity.Items.Add("Tekkalakota");
                ddlcity.Items.Add("Terdal");
                ddlcity.Items.Add("Tiptur");
                ddlcity.Items.Add("Tumkur");
                ddlcity.Items.Add("Udupi");
                ddlcity.Items.Add("Wadi");
                ddlcity.Items.Add("Yadgir");
                break;


            //18-Kerala
            case 18:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Attingal");
                ddlcity.Items.Add("Ashtamichira");
                ddlcity.Items.Add("Aroor");
                ddlcity.Items.Add("Ancharakandy");
                ddlcity.Items.Add("Alappuzha");
                ddlcity.Items.Add("Adoor");
                ddlcity.Items.Add("Chalakudy");
                ddlcity.Items.Add("Changanassery");
                ddlcity.Items.Add("Chendamangalam");
                ddlcity.Items.Add("Cherthala");
                ddlcity.Items.Add("Cheruthazham");
                ddlcity.Items.Add("Chittur-Thathamangalam");
                ddlcity.Items.Add("Chockli");
                ddlcity.Items.Add("Erattupetta");
                ddlcity.Items.Add("Guruvayoor");
                ddlcity.Items.Add("Irinjalakuda");
                ddlcity.Items.Add("Kadirur");
                ddlcity.Items.Add("Kalliasseri");
                ddlcity.Items.Add("Kalpetta");
                ddlcity.Items.Add("Kanhangad");
                ddlcity.Items.Add("Kanjikkuzhi");
                ddlcity.Items.Add("Kannur");
                ddlcity.Items.Add("Kasaragod");
                ddlcity.Items.Add("Kayamkulam");
                ddlcity.Items.Add("Kochi");
                ddlcity.Items.Add("Kodungallur");
                ddlcity.Items.Add("Kollam");
                ddlcity.Items.Add("Koothuparamba");
                ddlcity.Items.Add("Kothamangalam");
                ddlcity.Items.Add("Kottayam");
                ddlcity.Items.Add("Kozhikode");
                ddlcity.Items.Add("Kunnamkulam");
                ddlcity.Items.Add("Malappuram");
                ddlcity.Items.Add("Mattannur");
                ddlcity.Items.Add("Mavelikkara");
                ddlcity.Items.Add("Mavoor");
                ddlcity.Items.Add("Muvattupuzha");
                ddlcity.Items.Add("Nedumangad");
                ddlcity.Items.Add("Neyyattinkara");
                ddlcity.Items.Add("Ottappalam");
                ddlcity.Items.Add("Palai");
                ddlcity.Items.Add("Palakkad");
                ddlcity.Items.Add("Panniyannur");
                ddlcity.Items.Add("Pappinisseri");
                ddlcity.Items.Add("Paravoor");
                ddlcity.Items.Add("Pathanamthitta");
                ddlcity.Items.Add("Payyannur");
                ddlcity.Items.Add("Peringathur");
                ddlcity.Items.Add("Perinthalmanna");
                ddlcity.Items.Add("Perumbavoor");
                ddlcity.Items.Add("Ponnani");
                ddlcity.Items.Add("Punalur");
                ddlcity.Items.Add("Quilandy");
                ddlcity.Items.Add("Shoranur");
                ddlcity.Items.Add("Taliparamba");
                ddlcity.Items.Add("Thiruvalla");
                ddlcity.Items.Add("Thiruvananthapuram*");
                ddlcity.Items.Add("Thrissur");
                ddlcity.Items.Add("Thodupuzha");
                ddlcity.Items.Add("Tirur");
                ddlcity.Items.Add("Vaikom");
                ddlcity.Items.Add("Varkala");
                ddlcity.Items.Add("Vadakara");
                break;


            //19-Lakshadweep
            case 19:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Kavaratti*");
                break;


            //20-Madhya Pradesh
            case 20:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Ashok Nagar");
                ddlcity.Items.Add("Balaghat");
                ddlcity.Items.Add("Betul");
                ddlcity.Items.Add("Bhopal*");
                ddlcity.Items.Add("Burhanpur");
                ddlcity.Items.Add("Dabra");
                ddlcity.Items.Add("Datia");
                ddlcity.Items.Add("Dewas");
                ddlcity.Items.Add("Dhar");
                ddlcity.Items.Add("Fatehabad");
                ddlcity.Items.Add("Gwalior");
                ddlcity.Items.Add("Indore");
                ddlcity.Items.Add("Itarsi");
                ddlcity.Items.Add("Jabalpur");
                ddlcity.Items.Add("Katni");
                ddlcity.Items.Add("Kotma");
                ddlcity.Items.Add("Lahar");
                ddlcity.Items.Add("Lundi");
                ddlcity.Items.Add("Narsinghgarh (Damoh)");
                ddlcity.Items.Add("Narsinghgarh (Rajgarh)");
                ddlcity.Items.Add("Rajgarh (Dhar)");
                ddlcity.Items.Add("Rajgarh (Rajgarh)");
                ddlcity.Items.Add("Ramnagar");
                ddlcity.Items.Add("Ratangarh");
                ddlcity.Items.Add("Sagar");
                ddlcity.Items.Add("Satna");
                ddlcity.Items.Add("Tarana");
                ddlcity.Items.Add("Tikamgarh");
                ddlcity.Items.Add("Ujhani");
                ddlcity.Items.Add("Ujjain");
                ddlcity.Items.Add("Umaria");
                ddlcity.Items.Add("Vidisha");
                ddlcity.Items.Add("Wara Seoni");
                break;


            //21-Maharastra
            case 21:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Achalpur");
                ddlcity.Items.Add("Ahmednagar");
                ddlcity.Items.Add("Akolal");
                ddlcity.Items.Add("Amravati");
                ddlcity.Items.Add("Aurangabad");
                ddlcity.Items.Add("Chalisgaon");
                ddlcity.Items.Add("Devgarh");
                ddlcity.Items.Add("Dombivli");
                ddlcity.Items.Add("Durgapur");
                ddlcity.Items.Add("Ichalkaranji");
                ddlcity.Items.Add("Jalna");
                ddlcity.Items.Add("Latur");
                ddlcity.Items.Add("Loha");
                ddlcity.Items.Add("Lonar");
                ddlcity.Items.Add("Lonavla");
                ddlcity.Items.Add("Malegaon");
                ddlcity.Items.Add("Manchar");
                ddlcity.Items.Add("Miraj");
                ddlcity.Items.Add("Mumbai*");
                ddlcity.Items.Add("Nagpur");
                ddlcity.Items.Add("Nashik");
                ddlcity.Items.Add("Navi Mumbai");
                ddlcity.Items.Add("Osmanabad");
                ddlcity.Items.Add("Ozar");
                ddlcity.Items.Add("Panvel");
                ddlcity.Items.Add("Pune");
                ddlcity.Items.Add("Rajgurunagar");
                ddlcity.Items.Add("Sailu");
                ddlcity.Items.Add("Sangamner");
                ddlcity.Items.Add("Sangli");
                ddlcity.Items.Add("Sangole");
                ddlcity.Items.Add("Sasvad");
                ddlcity.Items.Add("Satana");
                ddlcity.Items.Add("Savner");
                ddlcity.Items.Add("Sawantwadi");
                ddlcity.Items.Add("Shahade");
                ddlcity.Items.Add("Shegaon");
                ddlcity.Items.Add("Shendurjana");
                ddlcity.Items.Add("Shirdi");
                ddlcity.Items.Add("Shirpur-Warwade");
                ddlcity.Items.Add("Shirur");
                ddlcity.Items.Add("Shrigonda");
                ddlcity.Items.Add("Shrirampur");
                ddlcity.Items.Add("Sillod");
                ddlcity.Items.Add("Sinnar");
                ddlcity.Items.Add("Solapur");
                ddlcity.Items.Add("Soyagaon");
                ddlcity.Items.Add("Talegaon Dabhade");
                ddlcity.Items.Add("Talode");
                ddlcity.Items.Add("Tasgaon");
                ddlcity.Items.Add("Tirora");
                ddlcity.Items.Add("Tuljapur");
                ddlcity.Items.Add("Tumsar");
                ddlcity.Items.Add("Uchgaon");
                ddlcity.Items.Add("Udgir");
                ddlcity.Items.Add("Umarga");
                ddlcity.Items.Add("Umarkhed");
                ddlcity.Items.Add("Umred");
                ddlcity.Items.Add("Uran");
                ddlcity.Items.Add("Uran Islampur");
                ddlcity.Items.Add("Vadgaon Kasba");
                ddlcity.Items.Add("Vaijapur");
                ddlcity.Items.Add("Vasai");
                ddlcity.Items.Add("Virar");
                ddlcity.Items.Add("Vita");
                ddlcity.Items.Add("Wadgaon Road");
                ddlcity.Items.Add("Wai");
                ddlcity.Items.Add("Wani");
                ddlcity.Items.Add("Wardha");
                ddlcity.Items.Add("Warora");
                ddlcity.Items.Add("Warud");
                ddlcity.Items.Add("Washim");
                ddlcity.Items.Add("Yavatmal");
                ddlcity.Items.Add("Yawal");
                ddlcity.Items.Add("Yevla");
                break;


            //22-Manipur
            case 22:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Imphal*");
                ddlcity.Items.Add("Kakching");
                ddlcity.Items.Add("Lilong");
                ddlcity.Items.Add("Mayang Imphal");
                ddlcity.Items.Add("Thoubal");
                break;


            //23-Meghalya
            case 23:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Shillong*");
                ddlcity.Items.Add("Champhai");
                ddlcity.Items.Add("Lunglei");
                break;


            //24-Mizoram
            case 24:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Aizawl*");
                ddlcity.Items.Add("Dimapur");
                ddlcity.Items.Add("Kohima*");
                ddlcity.Items.Add("Mokokchung");
                ddlcity.Items.Add("Tuensang");
                ddlcity.Items.Add("Wokha");
                ddlcity.Items.Add("Zunheboto");
                break;


            //25-Nagaland
            case 25:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Anandapur");
                ddlcity.Items.Add("Anugul");
                ddlcity.Items.Add("Asika");
                ddlcity.Items.Add("Balangir");
                ddlcity.Items.Add("Balasore");
                ddlcity.Items.Add("Baleshwar");
                ddlcity.Items.Add("Barbil");
                ddlcity.Items.Add("Bargarh");
                ddlcity.Items.Add("Baripada");
                ddlcity.Items.Add("Basudebpur");
                ddlcity.Items.Add("Belpahar");
                ddlcity.Items.Add("Bhadrak");
                ddlcity.Items.Add("Bhawanipatna");
                ddlcity.Items.Add("Bhuban");
                ddlcity.Items.Add("Bhubaneswar*");
                ddlcity.Items.Add("Biramitrapur");
                ddlcity.Items.Add("Brahmapur");
                ddlcity.Items.Add("Brajrajnagar");
                ddlcity.Items.Add("Byasanagar");
                ddlcity.Items.Add("Bargarh");
                ddlcity.Items.Add("Chhatarpur");
                ddlcity.Items.Add("Cuttack");
                ddlcity.Items.Add("Debagarh");
                ddlcity.Items.Add("Dhenkanal");
                ddlcity.Items.Add("Gunupur");
                ddlcity.Items.Add("Hinjilicut");
                ddlcity.Items.Add("Jagatsinghapur");
                ddlcity.Items.Add("Jajapur");
                ddlcity.Items.Add("Jaleswar");
                ddlcity.Items.Add("Jatani");
                ddlcity.Items.Add("Jeypur");
                ddlcity.Items.Add("Jharsuguda");
                ddlcity.Items.Add("Joda");
                ddlcity.Items.Add("Kantabanji");
                ddlcity.Items.Add("Karanjia");
                ddlcity.Items.Add("Kendrapara");
                ddlcity.Items.Add("Kendujhar");
                ddlcity.Items.Add("Khordha");
                ddlcity.Items.Add("Kohima*");
                ddlcity.Items.Add("Koraput");
                ddlcity.Items.Add("Malkangiri");
                ddlcity.Items.Add("Nabarangapur");
                ddlcity.Items.Add("Paradip");
                ddlcity.Items.Add("Parlakhemundi");
                ddlcity.Items.Add("Pattamundai");
                ddlcity.Items.Add("Phulabani");
                ddlcity.Items.Add("Puri");
                ddlcity.Items.Add("Rairangpur");
                ddlcity.Items.Add("Rajagangapur");
                ddlcity.Items.Add("Raurkela");
                ddlcity.Items.Add("Rayagada");
                ddlcity.Items.Add("Rayagada");
                ddlcity.Items.Add("Soro");
                ddlcity.Items.Add("Sunabeda");
                ddlcity.Items.Add("Sundargarh");
                ddlcity.Items.Add("Talcher");
                ddlcity.Items.Add("Titlagarh");
                ddlcity.Items.Add("Umarkote");
                break;


            //26-Orissa
            case 26:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Bhubaneswar*");
                break;


            //27-Puducherry
            case 27:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Puducherry*");
                break;


            //28-Punjab
            case 28:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Abohar");
                ddlcity.Items.Add("Ahmedgarh");
                ddlcity.Items.Add("Amritsar");
                ddlcity.Items.Add("Barnala");
                ddlcity.Items.Add("Batala");
                ddlcity.Items.Add("Bathinda");
                ddlcity.Items.Add("Bhagha Purana");
                ddlcity.Items.Add("Budhlada");
                ddlcity.Items.Add("Chandigarh*");
                ddlcity.Items.Add("Dasua");
                ddlcity.Items.Add("Dhuri");
                ddlcity.Items.Add("Dinanagar");
                ddlcity.Items.Add("Faridkot");
                ddlcity.Items.Add("Fazilka");
                ddlcity.Items.Add("Firozpur");
                ddlcity.Items.Add("Firozpur Cantt");
                ddlcity.Items.Add("Giddarbaha");
                ddlcity.Items.Add("Gobindgarh");
                ddlcity.Items.Add("Gurdaspur");
                ddlcity.Items.Add("Hoshiarpur");
                ddlcity.Items.Add("Jagraon");
                ddlcity.Items.Add("Jaitu");
                ddlcity.Items.Add("Jalalabad");
                ddlcity.Items.Add("Jalandhar Cantt.");
                ddlcity.Items.Add("Jalandhar");
                ddlcity.Items.Add("Jandiala");
                ddlcity.Items.Add("Kapurthala");
                ddlcity.Items.Add("Karoran");
                ddlcity.Items.Add("Kartarpur");
                ddlcity.Items.Add("Khanna");
                ddlcity.Items.Add("Kharar");
                ddlcity.Items.Add("Kot Kapura");
                ddlcity.Items.Add("Kurali");
                ddlcity.Items.Add("Longowal");
                ddlcity.Items.Add("Ludhiana");
                ddlcity.Items.Add("Malerkotla");
                ddlcity.Items.Add("Malout");
                ddlcity.Items.Add("Mansa");
                ddlcity.Items.Add("Maur");
                ddlcity.Items.Add("Moga");
                ddlcity.Items.Add("Mohali");
                ddlcity.Items.Add("Morinda");
                ddlcity.Items.Add("Mukerian");
                ddlcity.Items.Add("Muktsar");
                ddlcity.Items.Add("Nabha");
                ddlcity.Items.Add("Nakodar");
                ddlcity.Items.Add("Nangal");
                ddlcity.Items.Add("Nawanshahr");
                ddlcity.Items.Add("Pathankot");
                ddlcity.Items.Add("Patiala");
                ddlcity.Items.Add("Patran");
                ddlcity.Items.Add("Patti");
                ddlcity.Items.Add("Phagwara");
                ddlcity.Items.Add("Phillaur");
                ddlcity.Items.Add("Qadian");
                ddlcity.Items.Add("Raikot");
                ddlcity.Items.Add("Rajpura");
                ddlcity.Items.Add("Rampura Phul");
                ddlcity.Items.Add("Rupnagar");
                ddlcity.Items.Add("Samana");
                ddlcity.Items.Add("Sangrur");
                ddlcity.Items.Add("Sirhind Fatehgarh Sahib");
                ddlcity.Items.Add("Sujanpur");
                ddlcity.Items.Add("Sunam");
                ddlcity.Items.Add("Talwara");
                ddlcity.Items.Add("Tarn Taran");
                ddlcity.Items.Add("Urmar Tanda");
                ddlcity.Items.Add("Zira");
                ddlcity.Items.Add("Zirakpur");
                break;


            //Rajasthan
            case 29:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Ajmer");
                ddlcity.Items.Add("Alwar");
                ddlcity.Items.Add("Bandikui");
                ddlcity.Items.Add("Barmer");
                ddlcity.Items.Add("Bikaner");
                ddlcity.Items.Add("Fatehpur");
                ddlcity.Items.Add("Jaipur*");
                ddlcity.Items.Add("Jaisalmer");
                ddlcity.Items.Add("Jodhpur");
                ddlcity.Items.Add("Kota");
                ddlcity.Items.Add("Lachhmangarh");
                ddlcity.Items.Add("Ladnu");
                ddlcity.Items.Add("Lakheri");
                ddlcity.Items.Add("Lalsot");
                ddlcity.Items.Add("Losal");
                ddlcity.Items.Add("Nawalgarh");
                ddlcity.Items.Add("Pilani");
                ddlcity.Items.Add("Pokaran");
                ddlcity.Items.Add("Prantij");
                ddlcity.Items.Add("Pratapgarh");
                ddlcity.Items.Add("Pushkar");
                ddlcity.Items.Add("Rajgarh (Alwar)");
                ddlcity.Items.Add("Rajgarh (Churu");
                ddlcity.Items.Add("Ramagarh");
                ddlcity.Items.Add("Rani");
                ddlcity.Items.Add("Ratangarh");
                ddlcity.Items.Add("Sadri");
                ddlcity.Items.Add("Sadulshahar");
                ddlcity.Items.Add("Sagwara");
                ddlcity.Items.Add("Sambhar");
                ddlcity.Items.Add("Sanchore");
                ddlcity.Items.Add("Sangaria");
                ddlcity.Items.Add("Sardarshahar");
                ddlcity.Items.Add("Sawai Madhopur");
                ddlcity.Items.Add("Shahpura");
                ddlcity.Items.Add("Shahpura");
                ddlcity.Items.Add("Sheoganj");
                ddlcity.Items.Add("Sikar");
                ddlcity.Items.Add("Sirohi");
                ddlcity.Items.Add("Sojat");
                ddlcity.Items.Add("Sriganganagar");
                ddlcity.Items.Add("Sri Madhopur");
                ddlcity.Items.Add("Sujangarh");
                ddlcity.Items.Add("Sumerpur");
                ddlcity.Items.Add("Suratgarh");
                ddlcity.Items.Add("Taranagar");
                ddlcity.Items.Add("Todabhim");
                ddlcity.Items.Add("Todaraisingh");
                ddlcity.Items.Add("Tonk");
                ddlcity.Items.Add("Udaipur");
                ddlcity.Items.Add("Udaipurwati");
                ddlcity.Items.Add("Vijainagar");
                break;


            //Sikkim
            case 30:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Gangtok*");
                break;


            //Tamil Nadu
            case 31:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Arakkonam");
                ddlcity.Items.Add("Arcot");
                ddlcity.Items.Add("Aruppukkottai");
                ddlcity.Items.Add("Bhavani");
                ddlcity.Items.Add("Chengalpattu");
                ddlcity.Items.Add("Chennai*");
                ddlcity.Items.Add("Coimbatore");
                ddlcity.Items.Add("Coonoor");
                ddlcity.Items.Add("Cuddalore");
                ddlcity.Items.Add("Dindigul");
                ddlcity.Items.Add("Gudalur");
                ddlcity.Items.Add("Kanchipuram");
                ddlcity.Items.Add("Karaikudi");
                ddlcity.Items.Add("Karur");
                ddlcity.Items.Add("Karungal");
                ddlcity.Items.Add("Lalgudi");
                ddlcity.Items.Add("Madurai");
                ddlcity.Items.Add("Nagapattinam");
                ddlcity.Items.Add("Nagercoil");
                ddlcity.Items.Add("Namakkal");
                ddlcity.Items.Add("O Valley");
                ddlcity.Items.Add("Oddanchatram");
                ddlcity.Items.Add("Pollachi");
                ddlcity.Items.Add("Pudukkottai");
                ddlcity.Items.Add("Rajapalayam");
                ddlcity.Items.Add("Ramanathapuram");
                ddlcity.Items.Add("Rameshwaram");
                ddlcity.Items.Add("Salem");
                ddlcity.Items.Add("Sathyamangalam");
                ddlcity.Items.Add("Sivakasi");
                ddlcity.Items.Add("Tenkasi");
                ddlcity.Items.Add("Thammampatti");
                ddlcity.Items.Add("Thanjavur");
                ddlcity.Items.Add("Tharamangalam");
                ddlcity.Items.Add("Tharangambadi");
                ddlcity.Items.Add("Theni Allinagaram");
                ddlcity.Items.Add("Thirumangalam");
                ddlcity.Items.Add("Thirunindravur");
                ddlcity.Items.Add("Thiruparappu");
                ddlcity.Items.Add("Thirupuvanam");
                ddlcity.Items.Add("Thiruthuraipoondi");
                ddlcity.Items.Add("Thiruvallur");
                ddlcity.Items.Add("Thiruvarur");
                ddlcity.Items.Add("Thoothukudi");
                ddlcity.Items.Add("Thuraiyur");
                ddlcity.Items.Add("Tindivanam");
                ddlcity.Items.Add("Tiruchendur");
                ddlcity.Items.Add("Tiruchengode");
                ddlcity.Items.Add("Tiruchirappalli");
                ddlcity.Items.Add("Tirukalukundram");
                ddlcity.Items.Add("Tirukkoyilur");
                ddlcity.Items.Add("Tirunelveli");
                ddlcity.Items.Add("Tirupathur");
                ddlcity.Items.Add("Tiruppur");
                ddlcity.Items.Add("Tiruttani");
                ddlcity.Items.Add("Tiruvannamalai");
                ddlcity.Items.Add("Tiruvethipuram");
                ddlcity.Items.Add("Tittakudi");
                ddlcity.Items.Add("Udhagamandalam");
                ddlcity.Items.Add("Udumalaipetta");
                ddlcity.Items.Add("Unnamalaikadai");
                ddlcity.Items.Add("Usilampatti");
                ddlcity.Items.Add("Uthamapalayam");
                ddlcity.Items.Add("Uthiramerur");
                ddlcity.Items.Add("Vadakkuvalliyur");
                ddlcity.Items.Add("Vadalur");
                ddlcity.Items.Add("Vadipatti");
                ddlcity.Items.Add("Valparai");
                ddlcity.Items.Add("Vandavasi");
                ddlcity.Items.Add("Vaniyambadi");
                ddlcity.Items.Add("Vedaranyam");
                ddlcity.Items.Add("Vellakoil");
                ddlcity.Items.Add("Vellore");
                ddlcity.Items.Add("Vikramasingapuram");
                ddlcity.Items.Add("Viluppuram");
                ddlcity.Items.Add("Virudhachalam");
                ddlcity.Items.Add("Virudhunagar");
                ddlcity.Items.Add("Viswanatham");
                break;


            //Tripura
            case 32:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Agartala*");
                ddlcity.Items.Add("Badharghat");
                ddlcity.Items.Add("Dharmanagar");
                ddlcity.Items.Add("Indranagar");
                ddlcity.Items.Add("Jogendranagar");
                ddlcity.Items.Add("Kailasahar");
                ddlcity.Items.Add("Khowai");
                ddlcity.Items.Add("Pratapgarh");
                ddlcity.Items.Add("Udaipur");
                break;


            //Uttarakhand
            case 33:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Chamba");
                ddlcity.Items.Add("Dehradun*");
                break;


            //Uttar Pradesh
            case 34:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Agra");
                ddlcity.Items.Add("Aligarh");
                ddlcity.Items.Add("Allahabad");
                ddlcity.Items.Add("Amroha");
                ddlcity.Items.Add("Azamgarh");
                ddlcity.Items.Add("Bahraich");
                ddlcity.Items.Add("Ballia");
                ddlcity.Items.Add("Balrampur");
                ddlcity.Items.Add("Banda");
                ddlcity.Items.Add("Bareilly");
                ddlcity.Items.Add("Chandausi");
                ddlcity.Items.Add("Etawah");
                ddlcity.Items.Add("Fatehabad");
                ddlcity.Items.Add("Fatehpur");
                ddlcity.Items.Add("Greater Noida");
                ddlcity.Items.Add("Hamirpur");
                ddlcity.Items.Add("Hardoi");
                ddlcity.Items.Add("Jaunpur");
                ddlcity.Items.Add("Jhansi");
                ddlcity.Items.Add("Kanpur");
                ddlcity.Items.Add("Kota");
                ddlcity.Items.Add("Laharpur");
                ddlcity.Items.Add("Lakhimpur kheeri");
                ddlcity.Items.Add("Lal Gopalganj");
                ddlcity.Items.Add("Lalitpur");
                ddlcity.Items.Add("Lalganj");
                ddlcity.Items.Add("Lar");
                ddlcity.Items.Add("Loni");
                ddlcity.Items.Add("Lucknow*");
                ddlcity.Items.Add("Mathura");
                ddlcity.Items.Add("Meerut");
                ddlcity.Items.Add("Muradnagar");
                ddlcity.Items.Add("NOIDA");
                ddlcity.Items.Add("Nizamabad");
                ddlcity.Items.Add("Obra");
                ddlcity.Items.Add("Orai");
                ddlcity.Items.Add("Pratapgarh");
                ddlcity.Items.Add("Rae Bareli");
                ddlcity.Items.Add("Ramnagar");
                ddlcity.Items.Add("Rampur");
                ddlcity.Items.Add("Sirsa");
                ddlcity.Items.Add("Tanda");
                ddlcity.Items.Add("Tetri Bazar");
                ddlcity.Items.Add("Thakurdwara");
                ddlcity.Items.Add("Thana Bhawan");
                ddlcity.Items.Add("Tilhar");
                ddlcity.Items.Add("Tirwaganj");
                ddlcity.Items.Add("Tulsipur");
                ddlcity.Items.Add("Tundla");
                ddlcity.Items.Add("Unnao");
                ddlcity.Items.Add("Utraula");
                ddlcity.Items.Add("Varanasi");
                ddlcity.Items.Add("Vrindavan");
                ddlcity.Items.Add("Warhapur");
                ddlcity.Items.Add("Zaidpur");
                ddlcity.Items.Add("Zamania");
                break;

            //West Bengal
            case 35:
                ddlcity.Items.Clear();
                ddlcity.Items.Add("Adra, Purulia");
                ddlcity.Items.Add("Alipurduar");
                ddlcity.Items.Add("Arambagh");
                ddlcity.Items.Add("Asansol");
                ddlcity.Items.Add("Baharampur");
                ddlcity.Items.Add("Bally");
                ddlcity.Items.Add("Balurghat");
                ddlcity.Items.Add("Bankura");
                ddlcity.Items.Add("Barasat");
                ddlcity.Items.Add("Bardhaman");
                ddlcity.Items.Add("Barakar");
                ddlcity.Items.Add("Bidhan Nagar");
                ddlcity.Items.Add("Calcutta");
                ddlcity.Items.Add("Chandannagar");
                ddlcity.Items.Add("Chinsura");
                ddlcity.Items.Add("Contai");
                ddlcity.Items.Add("Cooch Behar");
                ddlcity.Items.Add("Darjeeling");
                ddlcity.Items.Add("Durgapur");
                ddlcity.Items.Add("Haldia");
                ddlcity.Items.Add("Howrah");
                ddlcity.Items.Add("Islampur");
                ddlcity.Items.Add("Kharagpur");
                ddlcity.Items.Add("Kolkata*");
                ddlcity.Items.Add("Murshidabad");
                ddlcity.Items.Add("Naihati");
                ddlcity.Items.Add("Purulia");
                ddlcity.Items.Add("Ramnagar(Asansol)");
                ddlcity.Items.Add("Ramnagar(Durgapur)");
                ddlcity.Items.Add("Ramnagar(Purba Medinipur)");
                ddlcity.Items.Add("Sainthia");
                ddlcity.Items.Add("Santipur");
                ddlcity.Items.Add("Siliguri");
                ddlcity.Items.Add("Sonamukhi");
                ddlcity.Items.Add("Suri");
                ddlcity.Items.Add("Tadpatri");
                ddlcity.Items.Add("Tamluk");
                ddlcity.Items.Add("Tarakeswar");
                break;

        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(txtpswrd.Text);
            data = x.ComputeHash(data);
            string password = System.Text.Encoding.ASCII.GetString(data);


            string sql = "Insert into UserAccount(firstname,lastname,email_ID,Password,gender,birthdate,state,city,mobile_no,Zipcode,security_Question,Answer,Designation,entrydate)Values('" + txtname.Text + "','" + txtlstname.Text + "','" + txtemail.Text + "','" + password + "','" + RadioButtonList1.SelectedItem.ToString() + "','" + txtdate.Text + "','" + ddlstate.SelectedItem.ToString() + "','" + ddlcity.SelectedItem.ToString() + "'," + txtmobileno.Text + ",'" + txtzipcode.Text + "','" + ddlquestion.SelectedItem.ToString() + "','" + txtanswer.Text + "','" + txtdesignation.Text + "', getdate())";
            int a = 0;
            a = css.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is Not Saved";
            }
            else
            {
                
                txtdate.Text = "";
                txtname.Text = "";
                txtlstname.Text = "";
                txtemail.Text = "";
                txtpswrd.Text = "";
                //txtcnfirmpsd.Text = "";
                txtmobileno.Text = "";
                txtzipcode.Text = "";
                txtanswer.Text = "";
                txtdesignation.Text = "";
                ddlstate.SelectedIndex = 0;
                ddlcity.SelectedIndex = 0;
                lblmsg.Text = "Data is Saved";
            }
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
}
