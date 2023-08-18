using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Calculo : MonoBehaviour
{
    
    //Variaveis
	
    public TMP_InputField peso;
    public TMP_InputField idade;
    public TMP_InputField altura;

    public Text Imc;
    public float imcR;


    

    //Button
    [SerializeField] private GameObject Verde;
    [SerializeField] private GameObject Vermelho;
    [SerializeField] private GameObject Amarelo;
    




    //Valores para converter
    string ValorPeso;
    string ValorIdade;
    string ValorAltura;
	
    
    //Metodo de conversao
    float pesoConvertido;
    float alturaConvertida;
    float idadeConvertida;
	float imcConvertido;
    
   

    public void Start()
    {
        Verde.SetActive(true);
        Vermelho.SetActive(true);
        Amarelo.SetActive(true);

        //
    }

 
    public void calcular()

    {

        
       

        string ValorPeso = peso.text;
        string ValorAltura = altura.text;
        string ValorIdade = idade.text;
        
       

        
        float.TryParse(ValorAltura, out alturaConvertida);
        float.TryParse(ValorIdade, out idadeConvertida);
        float.TryParse(ValorPeso, out pesoConvertido);


        float imc = pesoConvertido / (alturaConvertida * alturaConvertida);

        string imcTexto = imc.ToString();

        Imc.text = imcTexto;

        Debug.Log(imcTexto);

        //idade 3

        if (idadeConvertida == 3f)
        {
            
            if (alturaConvertida >= 88 && alturaConvertida <= 103)

            {
              if (pesoConvertido >= 11 && pesoConvertido <=18)
                {
                    Verde.SetActive(true);
                    Vermelho.SetActive(false);
                    Amarelo.SetActive(false);
                    Debug.Log("saudavel");

                    

                    
                    
                }
              else
                {
                    Vermelho.SetActive(true);
                    Verde.SetActive(false);
                    Amarelo.SetActive(false);
                    Debug.Log("Nao saudavel");
                    
                }
            }
        }
        //Idade 4
        if (idadeConvertida == 4f)
        {

            if (alturaConvertida >= 95 && alturaConvertida <= 112)

            {
                if (pesoConvertido >= 11 && pesoConvertido <= 21)
                {
                    Verde.SetActive(true);
                    Vermelho.SetActive(false);
                    Amarelo.SetActive(false);
                    Debug.Log("saudavel");
                }
                if (pesoConvertido == 21)
                {
                    Verde.SetActive(false);
                    Vermelho.SetActive(false);
                    Amarelo.SetActive(true);
                    Debug.Log("na media");
                }
                else
                {
                    Vermelho.SetActive(true);
                    Verde.SetActive(false);
                    Amarelo.SetActive(false);
                    Debug.Log("Nao saudavel");
                }
            }
        }
        //Idade 5
        if (idadeConvertida == 5f)
        {

            if (alturaConvertida >= 100 && alturaConvertida <= 118)

            {
                if (pesoConvertido >= 14 && pesoConvertido <= 23)
                {
                    Verde.SetActive(true);
                    Vermelho.SetActive(false);
                    Amarelo.SetActive(false);
                    Debug.Log("saudavel");
                }
                else
                {
                    Vermelho.SetActive(true);
                    Verde.SetActive(false);
                    Amarelo.SetActive(false);
                    Debug.Log("Nao saudavel");
                }
            }
        }
        //Idade 6

        if (idadeConvertida == 6f)
        {

            if (alturaConvertida >= 108 && alturaConvertida <= 125)

            {
                if (pesoConvertido >= 16 && pesoConvertido <= 26)
                {
                    Verde.SetActive(true);
                    Vermelho.SetActive(false);
                    Amarelo.SetActive(false);
                    Debug.Log("saudavel");
                }
                else
                {
                    Vermelho.SetActive(true);
                    Verde.SetActive(false);
                    Amarelo.SetActive(false);
                    Debug.Log("Nao saudavel");
                }
            }
        }
        //Idade 7

        if (idadeConvertida == 7f)
        {

            if (alturaConvertida >= 114 && alturaConvertida <= 131)

            {
                if (pesoConvertido >= 18 && pesoConvertido <= 30)
                {
                   

                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
              else
                {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 8

        if (idadeConvertida == 8f)
        {

            if (alturaConvertida >= 119 && alturaConvertida <= 137)

            {
                if (pesoConvertido >= 20 && pesoConvertido <= 35)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 9

        if (idadeConvertida == 9f)
        {

            if (alturaConvertida >= 123 && alturaConvertida <= 143)

            {
                if (pesoConvertido >= 22 && pesoConvertido <= 40)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 10

        if (idadeConvertida == 10f)
        {

            if (alturaConvertida >= 127 && alturaConvertida <= 149)

            {
                if (pesoConvertido >= 24 && pesoConvertido <= 46)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 11

        if (idadeConvertida == 11f)
        {

            if (alturaConvertida >= 132 && alturaConvertida <= 173)

            {
                if (pesoConvertido >= 26 && pesoConvertido <= 51)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 12

        if (idadeConvertida == 12f)
        {

            if (alturaConvertida >= 137 && alturaConvertida <= 164)

            {
                if (pesoConvertido >= 28 && pesoConvertido <= 57)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 13

        if (idadeConvertida == 13f)
        {

            if (alturaConvertida >= 143 && alturaConvertida <= 168)

            {
                if (pesoConvertido >= 32 && pesoConvertido <= 64)
                {
                    
                        
                            Verde.SetActive(true);
                            Vermelho.SetActive(false);
                            Amarelo.SetActive(false);
                            Debug.Log("saudavel");
                        }
              else
                {
                            Vermelho.SetActive(true);
                            Verde.SetActive(false);
                            Amarelo.SetActive(false);
                            Debug.Log("Nao saudavel");
                        }
                    }
        }
        //Idade 14

        if (idadeConvertida == 14f)
        {

            if (alturaConvertida >= 148 && alturaConvertida <= 170)

            {
                if (pesoConvertido >= 37 && pesoConvertido <= 68)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 15

        if (idadeConvertida == 15f)
        {

            if (alturaConvertida >= 150 && alturaConvertida <= 171)

            {
                if (pesoConvertido >= 40 && pesoConvertido <= 70)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 16

        if (idadeConvertida == 16f)
        {

            if (alturaConvertida >= 150 && alturaConvertida <= 172)

            {
                if (pesoConvertido >= 41 && pesoConvertido <= 71)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 17

        if (idadeConvertida == 17f)
        {

            if (alturaConvertida >= 151 && alturaConvertida <= 172)

            {
                if (pesoConvertido >= 42 && pesoConvertido <= 72)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
        //Idade 18

        if (idadeConvertida == 3f)
        {

            if (alturaConvertida >= 152 && alturaConvertida <= 172)

            {
                if (pesoConvertido >= 42 && pesoConvertido <= 72)
                    {
                        Verde.SetActive(true);
                        Vermelho.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("saudavel");
                    }
                    else
                    {
                        Vermelho.SetActive(true);
                        Verde.SetActive(false);
                        Amarelo.SetActive(false);
                        Debug.Log("Nao saudavel");
                    }
                }
        }
    }
}



