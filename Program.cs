namespace DFA
{
    public class Program
    {
        public static int Main(string[] args)
        {
            //Test one with simple DFA
            //==========================================================
            // List<char> alphabet = new List<char>() { 'a', 'b' };
            // List<State> states = new List<State>();
            // State q0 = new State("q0");
            // states.Add(q0);
            // State q1 = new State("q1");
            // states.Add(q1);
            // List<State> final = new List<State>() { q1 };
            // List<Transition> transitions = new List<Transition>();
            // transitions.Add(new Transition('b', q0, q0));
            // transitions.Add(new Transition('a', q0, q1));
            // transitions.Add(new Transition('a', q1, q1));
            // transitions.Add(new Transition('b', q1, q1));

            // StateMachine dfa = new StateMachine(alphabet, states, final, transitions, q0);

            // bool validDFA = dfa.validDFA();

            // bool acceptedString = dfa.acceptedString("a");
            // acceptedString = dfa.acceptedString("bb");
            // acceptedString = dfa.acceptedString("bababa");
            //==========================================================


            //Test 2
            List<char> alphabet = new List<char>() { '0', '1' };
            List<State> states = new List<State>();
            State q0 = new State("q0");
            states.Add(q0);
            State q1 = new State("q1");
            states.Add(q1);
            State q2 = new State("q2");
            states.Add(q2);
            List<State> final = new List<State>() { q1 };
            List<Transition> transitions = new List<Transition>();
            transitions.Add(new Transition('0', q0, q0));
            transitions.Add(new Transition('1', q0, q1));
            transitions.Add(new Transition('0', q1, q0));
            transitions.Add(new Transition('1', q1, q2));
            transitions.Add(new Transition('0', q2, q2));
            transitions.Add(new Transition('1', q2, q1));

            StateMachine dfa = new StateMachine(alphabet, states, final, transitions, q0);

            bool validDFA = dfa.validDFA();
            bool acceptedString = dfa.acceptedString("101");
            acceptedString = dfa.acceptedString("0111");
            acceptedString = dfa.acceptedString("11001");
            acceptedString = dfa.acceptedString("100");
            acceptedString = dfa.acceptedString("1100");

            return 0;
        }
    }
}