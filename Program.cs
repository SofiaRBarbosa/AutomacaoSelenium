
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class HelloSelenium { //Projeto de Automação de Testes//

    public void Caso1(IWebDriver driver){ //Metodos criados para serrem chamados na main//
            driver.Navigate().GoToUrl("https://google.com/");
            driver.FindElement(By.Name("q")).SendKeys("Horário de agora" + Keys.Enter); //Pesquisa sobre o horário atual e a localização, podendo ter alterações//
            IWebElement firstResult = driver.FindElement(By.ClassName("sL6Rbf")); 
            Console.WriteLine(firstResult.GetAttribute("textContent")); //a saída da pesquisa esperada//           
   }
    public void Caso2(IWebDriver driver){
            driver.Navigate().GoToUrl("https://google.com/"); 
            driver.FindElement(By.Name("q")).SendKeys("csharp" + Keys.Enter); //Pesquisa sobre a linguagem utilizada no código//
            IWebElement firstResult = driver.FindElement(By.ClassName("kno-rdesc"));
            Console.WriteLine(firstResult.GetAttribute("textContent"));         
   }              
    public void Caso3(IWebDriver driver){
            driver.Navigate().GoToUrl("https://google.com/");                 
            driver.FindElement(By.Name("q")).SendKeys("Dia de hoje" + Keys.Enter);//Pesquisa sobre a data de hoje,podendo ter alterações//
            IWebElement firstResult = driver.FindElement(By.ClassName("dDoNo"));
            Console.WriteLine(firstResult.GetAttribute("textContent"));
                
   } 
    public void Caso4(IWebDriver driver){
            driver.Navigate().GoToUrl("https://google.com/");    
             driver.FindElement(By.Name("q")).SendKeys("Previsão do tempo" + Keys.Enter);//Previsão do tempo em constante mudança, neste caso irá mostrar qual a probabilidade de chuva, a umidade e a velocidade do vento//
            IWebElement firstResult = driver.FindElement(By.ClassName("wtsRwe"));
            Console.WriteLine(firstResult.GetAttribute("textContent"));    
    }          
    public void Caso5(IWebDriver driver){
            driver.Navigate().GoToUrl("https://google.com/");    
            driver.FindElement(By.Name("q")).SendKeys("Vacinação Covid" + Keys.Enter);//Aparece o resultado de quantas pessoas já foram vacinadas no Brasil, podendo ter alterações//
            IWebElement firstResult = driver.FindElement(By.ClassName("wveNAf"));
            Console.WriteLine(firstResult.GetAttribute("textContent")); 
    }
    public void Caso6(IWebDriver driver){
            driver.Navigate().GoToUrl("https://google.com/");    
            driver.FindElement(By.Name("q")).SendKeys("Casos de COVID-19 no mundo" + Keys.Enter);// Resultado de quantos casos de covid e quantas mortes ocorridas//
            IWebElement firstResult = driver.FindElement(By.ClassName("wveNAf"));
            Console.WriteLine(firstResult.GetAttribute("textContent"));
    }
   public void Caso7(IWebDriver driver){
            driver.Navigate().GoToUrl("https://google.com/");    
            driver.FindElement(By.Name("q")).SendKeys("Noticias" + Keys.Enter);
            IWebElement firstResult = driver.FindElement(By.ClassName("kno-rdesc"));//De resultado um resumo sobre o google notícias//
            Console.WriteLine(firstResult.GetAttribute("textContent"));
    }

   public void Caso8(IWebDriver driver){
            driver.Navigate().GoToUrl("https://google.com/");    
            driver.FindElement(By.Name("q")).SendKeys("Youtube" + Keys.Enter);
            IWebElement firstResult = driver.FindElement(By.CssSelector("h3"));//Pesquisa de um reprodutor de vídeos específico//
            Console.WriteLine(firstResult.GetAttribute("textContent"));
    }

   public void Caso9(IWebDriver driver){
            driver.Navigate().GoToUrl("https://google.com/");    
            driver.FindElement(By.Name("q")).SendKeys("Sete Quedas Rio Verde" + Keys.Enter);//
            IWebElement firstResult = driver.FindElement(By.CssSelector("h3"));//Localização e descrição de um lugar de turismo//
            Console.WriteLine(firstResult.GetAttribute("textContent"));
    }
   public void Caso10(IWebDriver driver){
            driver.Navigate().GoToUrl("https://google.com/");    
            driver.FindElement(By.Name("q")).SendKeys("Bonito Ms" + Keys.Enter);
            IWebElement firstResult = driver.FindElement(By.ClassName("SPZz6b"));//Nome da cidade e Estado//
            Console.WriteLine(firstResult.GetAttribute("textContent"));
    }

  static void Main() {
    IWebDriver driver = new ChromeDriver(@"C:\Users\sofia\Downloads\chromedriver_win32(1)\");//Chamando o driver para ser iniciado//
    HelloSelenium search = new HelloSelenium();
    search.Caso1(driver); //Chamando os metodos, caso 1//
    search.Caso2(driver);//caso2//
    search.Caso3(driver);//caso3//
    search.Caso4(driver);//caso4//
    search.Caso5(driver);//caso5//
    search.Caso6(driver);//caso6//
    search.Caso7(driver);//caso7//
    search.Caso8(driver);//caso8//
    search.Caso9(driver);//caso9//
    search.Caso10(driver);//caso10//

    driver.Close();   //Fechamento do driver//
  }
}