public class Person {
    String navn;
    int alder;

    public Person(String navn, int alder){
        this.navn = navn;
        this.alder = alder;
    }

    public String getNavn (){return navn;}
    public int getAlder (){return alder;}
}