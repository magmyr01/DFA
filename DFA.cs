namespace DFA
{
    public class State
    {
        public string name;
        public State(string n) => name = n;
    }

    public class Transition
    {
        public State from, to;
        public char symbol;

        public Transition(char symbol, State fromS, State toS)
        {
            this.symbol = symbol;
            from = fromS;
            to = toS;
        }
    }

    public class StateMachine
    {
        public List<char> alphabet;
        public List<State> Q, F;
        public List<Transition> transitions;
        public State initial;

        public StateMachine(List<char> alph, List<State> states, List<State> finalStates, List<Transition> transitions, State initialState)
        {
            //Control that none of the fields are empty
            alphabet = alph;
            Q = states;
            F = finalStates;
            this.transitions = transitions;
            initial = initialState;
        }

        public bool validDFA()
        {
            foreach (State st in Q)
            {
                foreach (char c in alphabet)
                {
                    var tr = transitions.FindAll(t => t.from.Equals(st) && t.symbol == c);
                    if (tr.Count != 1)
                        return false;
                }
            }
            return true;
        }

        public bool acceptedString(string str)
        {
            State current = initial;
            string reminder = str;

            while (reminder.Count() > 0)
            {
                current = transitions.Find(p => p.from == current && p.symbol == reminder[0]).to;

                reminder = reminder.Remove(0, 1);
            }

            if (F.Contains(current))
                return true;
            else
                return false;
        }
    }
}