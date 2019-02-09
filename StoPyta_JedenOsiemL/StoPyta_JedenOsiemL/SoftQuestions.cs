using System;
using System.Collections.Generic;
using System.Text;

namespace StoPyta_JedenOsiemL
{
    public class SoftQuestions
    {
        private const int x = 25;
        private List<String> __questMaster;
        private LinkedList<String> __questShake;
        private int Randomness = 1;
        private Random randGen = new Random();

        public SoftQuestions()
        {
            __questMaster = new List<String>(new String[x]
            {
                "Wymień trzy seksowane części ciała drugiej osoby.",
                "Wymień pięć cech charakteru partnera, które Ci się w nim podobają.",
                "Wymień pięć rzeczy, które macie wspólne.",
                "Co sądzisz o wyrażaniu uczuć w miejscach publicznych?",
                "Na co szczególnie zwracasz uwagę u płci przeciwnej?",
                "Co myślisz o flirtowaniu w miejscu pracy?",
                "Co uważasz o randkowaniu przez internet?",
                "Co denerwuje Cię w płci przeciwnej podczas flirtu?",
                "Czy uważasz siebie za osobę atrakcyjną?",
                "Blondynki, czy brunetki? Dlaczego?",
                "Co jest ważniejsze? Seksapil, czy poczucie humoru?",
                "Opisz wymarzoną randkę.",
                "Co lepsze? Długotrwały związek, czy krótka przygoda?",
                "Czy masz na ciele jakieś znaki szczególne?",
                "Jaka potrawa jest największym afrodyzjakiem?",
                "Czego zazdrościsz płci przeciwnej?",
                "Czy taniec buduje napięcie?",
                "Co pomyślałeś, kiedy pierwszy raz zobaczyłeś swojego partnera?",
                "Przez co czujesz się seksowny?",
                "Czy wierzysz w idealny związek? Czym jest dla Ciebie miłość?",
                "Na początku relacji lepiej budować napięcie, czy być bezpośrednim?",
                "Czy to ty robisz pierwszy krok?",
                "Co sprawia, że czujesz się kochany?",
                "Naturalne piękno, czy mocny makijaż?",
                "Czy zwracasz uwagę na to jak gotuje Twój partner?",
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
