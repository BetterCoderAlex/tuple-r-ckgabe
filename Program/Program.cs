using System.Data;

public class Textinfo{
    private List<(char Name, int Wert)> _info = new();
    public List<(char Name,int Wert)> Info{
        get{
            return _info;
        }
    }
    private char[] Letters;

    public void Parser(){
        text = text.Replace(" ", "");
        text = text.ToLower();
        Letters = text.ToCharArray();
    }

    public void List_checker(){
        for(int i = 0; i < Letters.Length; i++){
            char tofind = Letters[i];
            int howoften = 0;
            foreach(var item in Letters){
                if (item == tofind){
                    howoften++;
                }
            }
            var toadd = (tofind, howoften);
            if (!_info.Contains(toadd)){
                _info.Add(toadd);
            }
        }
    }
    public void PrintParser(){
        for(int cnt = 0; cnt < Letters.Length; cnt++){
            Console.WriteLine(Letters[cnt]);
        }
    }
    public string text;
    public Textinfo(string input){
        text = input;
    }
}

public class Programm00{
    public static int Main(string[] args){
        Textinfo tmp = new("Hola die Waldfee");
        tmp.Parser();
        tmp.List_checker();
        for(int i = 0; i < tmp.Info.Count; i++){
            Console.WriteLine(tmp.Info[i]);
        }
        return 0;
    }
}