using System;
using System.Collections.Generic;
using System.Text;

namespace StoPyta_JedenOsiemL
{
    public class Questions
    {
        private const int x = 100;
        private List<String> __questMaster;
        private LinkedList<String> __questShake;
        private int Randomness = 1;
        private Random randGen = new Random();

        public Questions()
        {
            __questMaster = new List<String>(new String[x]
            {
            "Czy masz jakiś fetysz? Jeżeli tak, to jaki?",
            "Wymień jedną seksualną fantazję, której nie zrealizowałeś.",
            "Czego się krępujesz w sferze seksu?",
            "Co byłobu seksualną przesadą?",
            "Czy mógłbyś wziąć udział w trójkącie?",
            "Wymień trzy seksowane części ciała drugiej osoby.",
            "Wymień pięć cech charakteru partnera, które Ci się w nim podobają.",
            "Wymień pięć rzeczy, które macie wspólne.",
            "Co sądzisz o wyrażaniu uczuć w miejscach publicznych?",
            "Gdybyś mógł uprawiać seks w dowolnym miejscu na Ziemi, gdzie by to było?",
            "Jaki ubiór Cię szczególnie podnica?",
            "Jakich erotycznych zabawek chciałbyś spróbować?",
            "Najlepszy alkohol podczas wspólnego wieczoru to...?",
            "Jak wyobrażasz sobie idealną grę wstępną?",
            "Na co szczególnie zwracasz uwagę u płci przeciwnej?",
            "Lepszy romantyczny stosunek, czy walka o dominację?",
            "Wymień swoje najwrażliwsze miejsca na ciele.",
            "Lepszy seks z włączyonym, czy wyłączonym światłem? Dlaczego?",
            "W jakich godzinach masz największą ochotę?",
            "Wolisz dominować, czy być uległym?",
            "Co sądzisz o uprawianiu seksu do muzyki?",
            "Jak najbardziej lubisz, aby Twoje miejsca intymne były pieszczone?",
            "Ręką, czy ustami? Dlaczego?",
            "W pierwsze kolejności lepiej zaspokoić partnera, czy być zaspokojonym?",
            "Co seksownego chciałbyś usłyszeć od drugiej osoby?",
            "Co chciałbyś, aby druga osoba z Tobą zrobiła?",
            "Czy mógłbyś uprawiać seks do lecącego w tle porno?",
            "Co chciałbyś ulepszyć w swoim życiu seksualnym?",
            "Co myślisz o flirtowaniu w miejscu pracy?",
            "Czy byłbyś w stanie uprawiać seks w miejscu publicznym?",
            "Na co masz teraz ochotę?",
            "Jaka jest Twoja ulubiona pozycja?",
            "Który zapach jest najbardziej podniecający?",
            "Czy miałeś kiedyś orgazm będąc w ubraniu?",
            "Czy jesteś głośno podczas seksu?",
            "Co chciałbyś zrobić z drugim graczem?",
            "Co uważasz o randkowaniu przez internet?",
            "Powiedz o czymś, co lubisz robić podczas seksu.",
            "Co Cię najbardziej podnieca podczas seksu?",
            "Lepszy seks oralny, czy zwykły?",
            "Co uważasz o seksie analnym?",
            "Jak zareagowałbyś, gdybyś został przyłapany na seksie?",
            "Czy byłbyś w stanie uprawiać seks z osobą tej samej płci?",
            "Czy podnieca Cię, jak druga osoba się przy Tobie masturbuje?",
            "Co uważasz o fetyszu stóp?",
            "Czy byłbyś w wstanie wysłać komuś swoje nagie zdjęcia?",
            "Czy rozmiar ma dla Ciebie znaczenie?",
            "Jak najszybciej osiągasz orgazm?",
            "Czy lubisz jak w trakcie seksu druga osoba zjada Cię wzrokiem?",
            "Jakie porno podnieca Cię najbardziej?",
            "Co sądzisz o BDSM?",
            "Gdybyś miał opisać dobry seks jednym słowem, to jakim?",
            "Opisz jak byś to robił w osiedlowym parku, tak aby nikt nie zauważył.",
            "Jaki jest najlepszy rodzaj antykoncepcji?",
            "Na jakim miejscu na ciele najlepiej dojść?",
            "Lubisz podduszanie i ciągnięcie za włosy, czy jest to brak szacunku?",
            "Jakie subtelne gesty podniecają Cię najbardziej?",
            "Gdybyś miał na zawsze zrezygnować z jednej seksualnej pozycji to z jakiej?",
            "Jakiego seksualnego zachowania osób Twojej płci szczególnie nie tolerujesz?",
            "Co denerwuje Cię w płci przeciwnej podczas flirtu?",
            "Jaki jest najlepszy sposób, żeby zaciągnąć kogoś do łóżka?",
            "Czy uważasz siebie za osobę atrakcyjną?",
            "Co uważasz o seksie w aucie?",
            "Blondynki, czy brunetki? Dlaczego?",
            "Jaki jest idealny rozmiar piersi?",
            "Co jest ważniejsze? Seksapil, czy poczucie humoru?",
            "Czy kręcą Cię roleplay'e? Jeżeli tak, to w jaką postać chciałbyś się wcielić?",
            "Seks w wodzie - przyjemność, czy udręka?",
            "Jaki jest najlepszy widok szczytującego partnera?",
            "Co sądzisz o kobiecej dominacji podczas seksu?",
            "Opisz wymarzoną randkę.",
            "Czy masz na ciele jakieś znaki szczególne?",
            "Czego zazdrościsz płci przeciwnej?",
            "Czy są dni, w których masz większą ochotę niż zwykle? Od czego to zależy?",
            "Ile czasu byłbyś w stanie wytrzymać bez seksu?",
            "Jak często myślisz o seksie?",
            "Jak wyglądałby Twój wymarzony pokój zabaw?",
            "Co myślisz o seksie bez zabezpieczenia?",
            "Co lepsze? Długotrwały związek, czy krótka przygoda?",
            "Czy wspomagasz się jakimiś przedmiotami podczas masturbacji?",
            "Czy lubisz się masturbować?",
            "Jak często się masturbujesz? W jakim pomieszczeniu robisz to najczęściej?",
            "Połykać, czy wypluwać?",
            "Czy miewasz fantazje, że robisz to z kimś pomimo Twojej woli?",
            "Czy często robi Ci się mokro/twardo w majtkach?",
            "Czy ocierasz się czasem kroczem o domowe urządzenia?",
            "Czy miewasz fantazje o uprawianiu seksu z kimś kto śpi?",
            "Lateks - hot or not?",
            "Co sądzisz o swobodzie/rozwiązłości seksualnej kobiet?",
            "Czy podnieciłoby Cię samo zaspokojenie partnera?",
            "Jakie miejsca partnera najchętniej pieściłbyś językiem/ustami?",
            "Czy mówisz, że właśnie dochodzisz?",
            "Czy zdarza Ci się udawać orgazm?",
            "Czy boisz się, że usłyszą Cię sąsiedzi?",
            "Lubisz bezwstydny, dziki seks?",
            "Czy myślisz podczas seksu o tym jak wyglądasz?",
            "Czy zdarza Ci się myśleć podczas seksu o czymś innym?",
            "Czy chciałbyś zagrać w rozbieranego pokera?",
            "Jaka potrawa jest największym seksualnym afrodyzjakiem?",
            "Co seksownego chciałbyś dostać w prezencie?"
            });

            __questShake = MakeRandomList();
        }

        private LinkedList<String> MakeRandomList()
        {
            if (__questShake == null) __questShake = new LinkedList<string>();
            List<String> copy = new List<string>(__questMaster);

            for (int k = 0; k < Randomness; ++k)
            {
                for (int i = 0; i < copy.Count; ++i)
                {
                    int randIdx = randGen.Next() % copy.Count;
                    //zamiana elementów
                    String pom = copy[i];
                    copy[i] = copy[randIdx];
                    copy[randIdx] = pom;
                }
            }
            foreach (var Var in copy)
                __questShake.AddFirst(Var);
            return __questShake;
        }

        public String GetRandomQuestion()
        {
            String question;
            if (__questShake == null || __questShake.Count < 1)
                __questShake = MakeRandomList();
            question = __questShake.First.Value;
            __questShake.RemoveFirst();
            return question;
        }
    }
}
