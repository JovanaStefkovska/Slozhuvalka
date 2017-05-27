# Slozhuvalka

Документација за “Сложувалка”

##1. Опис на играта
Играта претставува имплементација на веќе познатата игра Fifteen puzzle, која ја проширивме со цел да обезбедиме комплетно задоволство кај играчот. Покрај чистиот и едноставен дизајн имплементиравме и полесно(почетничко) ниво, како и опции за пауза и помош. Оваа игра ви овозможува да изберете две нивоа зависи од тежината на сложувалката и тоа: 3x3 (Почетник) и 4x4 (Напредно) 

##2. Упатство за користење
###.2.1 Нова игра
 
 ![alt tag](https://image.prntscr.com/image/846d20dc66b94f35b7caa62142cfc816.png)
Слика 1

На почетниот прозорец(види слика 1) при стартување на апликацијата треба да го внесеме сопственото име на полето предвидено за внесување име, со клик на копчето “Избери” ни се отвара нов прозорец во кој одбираме сопствена слика од домашниот директориум. Третиот чекор што треба да го направиме е да избереме ниво на сложувалката. Ова е имплементирано со drop-down листа и корисникот  треба да избере почетничко ниво и напредно ниво. Доколку корисникот избере почетничко ниво сликата ќе биде поделена на 8 еднакви квадратчиња(види слика 2)  а доколку одбере напредно ниво сликата ќе биде поделена на 15 еднакви квадратчиња(види слика  3).  Доколку полињата за внесување име, слика и избирање  на ниво се пополнети се притиска на копчето “Започни со игра” и се отвара нов прозорец зависно од нивото што сме го одбрале. Доколку притиснеме на копчето а не се пополнети сите полиња се појавува error кај полето што не е пополнето.  

 ![alt tag](https://image.prntscr.com/image/f14f4ca5129c4767b14cd85ddebeabbc.png)
Слика 2

 ![alt tag](https://image.prntscr.com/image/33bef3f42ee4422387cec49142a38a66.png)
Слика 3


### 2.2 Започнување на играта
Откако ќе започнете со играта соодветните делови(квадратчиња) се размешуваат низ сложувалката и тајмерот за одбројување започнува да отчукува. Во долниот предел на прозорецот имаме три опции и тоа Помош, Пауза и Крај. Со притискање на копчето Помош се отвара нов прозорец со финалната слика што треба да ја составиме(види слика 4) исто така имплементирано е сликата да можеме да ја гледаме само 5 секунди и по завршување на времето се затвара прозорецот и се враќаме на играта. Имаме 5 можности за избирање на опцијата помош. 
 
 ![alt tag](https://image.prntscr.com/image/72a850f2b67e413b92ea2416fd2c50fa.png)
Слика 4

Со притискање на копчето Пауза квадратчињата односно деловите од сложувалката ги снемува и е прикажана позадината на играта и тајмерот запира. Со повторно притискање на истото копче, квадратчињата односно деловите од сложувалките повторно се појавуваат секое на своето место и тајмерот продолжува да отчукува.  
Со притискање на копчето Крај и проверува дали полињата се на вистински, и ако се на вистинско место се појавува нов дијалог “Браво + името на играчот + ја завршивте играта за X секунди” каде X е бројот на поминати секунди во играње. А доколку сложувалката не е довршена се појавува нова порака со тоа колку полиња се на вистинското место.

### 3. Подетален опис за изворниот код
### 3.1. Менување на големината на сликата
Со одбирање на слика од нашиот директориум ни претставуваше проблем да направиме квадрат од истата слика па така со функцијата “Bitmap Resize(Image img)” што како аргумент ја добиваме локацијата на сликата и ставаме променливи w и h и ги иницијализираме на 400  и со помош на “graphic.DrawImage(img, 0, 0, w, h);” добиваме квадрат и од слика што има димензии на правоаголник


        private Bitmap Resize(Image img)
        {   int w = 400;
            int h = 400;

            //create a new Bitmap the size of the new image
            Bitmap bmp = new Bitmap(w, h);
            //create a new graphic from the Bitmap
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //draw the newly resized image
            graphic.DrawImage(img, 0, 0, w, h);
            //dispose and free up the resources
            graphic.Dispose();
            //return the image
            return bmp;
        }

### 3.2. Паузирање на играта
Најпрвин имаме иницијализирана променлива flagTimer на 1 која ни служи како знаменце за тајмерот кој одбројува колку секунди игра играчот, и променлива canPlay = 1 која служи за дали може играчот да игра. Со притискање на копчето Пауза знаменцето за тајмерот го ставаме на 0 и тајмерот е во мирување и знаменцето за играње го сетираме на 0 и корисникот не може да продолжи да игра. Покрај оваа функционалност додадовме и да ги “снема” копчињата додека играта е на пауза со цел да не му се овозможи на играчот да си прави планови како да ја заврши играта а притоа да не му тече времето. Оваа функционалност е имплементирана со помош на button.Visible = false;

            if (flagTimer == 1)
            {
                canPlay = 0;
                flagTimer = 0;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;         
            }

### 3.3. Завршување на играта
При разместување на квадратчињата(деловите од сложувалката) паралелно на копчињата им додававме атрибут ImageKey со цел да знаеме дали квадратчињата се на вистинското место.

            int x = 0;
            foreach (Button b in containerPocetnik.Controls)
            {    
                b.ImageKey = "slika" + array[x].ToString();
                x++;
            }
            
И со притискање на копчето за Крај ги проверуваме сите копчиња дали се на соодветната локација. Во следниов код е прикажан за првото квадратче “slika0” кое треба да се наоѓа на локација со координати x=3 и y=3.

foreach (Button b in containerPocetnik.Controls)
            {
                if (b.ImageKey.Equals("slika0"))
                    if (b.Location.ToString().Equals("{X=3,Y=3}"))
                        krajIgra++; 
	}
  
Истава постапка се повторува за сите 8 копчиња за почетно ниво односно 15 копчиња за напредно ниво.

### Изработиле:

>- **Слободан Маринковиќ**
>- **Јована Стефковска**



