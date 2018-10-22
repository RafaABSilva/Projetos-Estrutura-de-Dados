
package Dominio;

public class Pessoa {
    
    private String nome;
    private int id;
    
    public Pessoa(){
        nome="";
        id=0;
    }
    
    public void setNome(String nome){
        this.nome=nome;
    }
    
    public void setID(int id){
        this.id=id;
    }
    
    public String getNome(){
        return nome;
    }
    
    public int getID(){
        return id;
    }
}
