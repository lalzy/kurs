public class Person {
    String fornavn;
    String etternavn;
    int alder;

    public Person(String fornavn = "", String etternavn = "", int alder = -1){
        this.fornavn = fornavn;
        this.etternavn = etternavn;
        this.alder = alder;
    }

    public void upper(){
        fornavn = Char.ToUpper(fornavn[0]) + fornavn.Substring(1);
        etternavn = Char.ToUpper(etternavn[0]) + etternavn.Substring(1);
    }

    public String getNavn (){return fornavn + " " + etternavn;}
    public String[] alleNavn(){return [fornavn, etternavn];}
    public int getAlder (){return alder;}
}