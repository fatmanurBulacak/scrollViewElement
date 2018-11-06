public void scroll(){
        
        IWebElement element = driver.FindElement(By.LinkText("Buraya elementin id,css vb. javascript bağlantısı yazılır"));
        
       //Seçenek 1 :Bu metot, öğeyi kaydıracak ve etkileşim için merkeze konumlandiracaktir
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", element);
        
        
        //Seçenek 2: Bu ise, öğeyi etkileşim görünümüne getirecektir. 
        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(false);", element);
            
        
        
}