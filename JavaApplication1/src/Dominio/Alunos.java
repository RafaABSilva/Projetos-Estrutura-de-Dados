
package Dominio;

public class Alunos extends Pessoa{
    
    private int RA;
    
    public Alunos(){
        super();
        RA=0;
    }
   
    
    public void setRA(int RA){
        this.RA=RA;
    }
    
    public int getRA(){
        return RA;
    }
}
