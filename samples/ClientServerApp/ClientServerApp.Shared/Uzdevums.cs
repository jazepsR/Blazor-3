using System;

namespace masterVersion
{
	[Serializable()]
	public class Uzdevums
	{
		private int id;
		private String text;
		private int grade;
		private String topic;
		private String subTopic;
		private int difficulty;
		private String[] equations;
		private String[] operatorStacks;
		private String[] varStacks;
		private bool isTheory;
		private String Answer;
		private bool isMultChoice;
		private String[] multChoices;
		private String[] imagePaths;
		

		public Uzdevums (){
		}

		public Uzdevums (int id, int grade,String topic,String text,int difficulty,String[] equation,String[] operatorStacks, String[] varStacks,
			bool isTheory, String Answer, bool isMultChoice, String[] multChoices,String subTopic = ""){
			this.id = id;
			this.grade = grade;
			this.topic = topic;
			this.text = text;
			this.difficulty = difficulty;
			this.equations = equation;
			this.operatorStacks = operatorStacks;
			this.varStacks = varStacks;
			this.isTheory = isTheory;
			this.Answer = Answer;
			this.isMultChoice = isMultChoice;
			this.multChoices = multChoices;
			this.subTopic = subTopic;
		}
		public Uzdevums ( int grade,String topic,String text,int difficulty,String[] equation,String[] operatorStacks, String[] varStacks,
			bool isTheory,String Answer, bool isMultChoice, String[] multChoices,String subTopic = ""):
		this (0, grade, topic, text, difficulty, equation,operatorStacks,varStacks,isTheory,Answer,isMultChoice,multChoices, subTopic){
		}

		public Uzdevums(int grade, String topic, String text, int difficulty) :
this(0, grade, topic, text, difficulty, null, null, null, false, null, false, null)
		{
		}
		public Uzdevums(int id,int grade, String topic, String text, int difficulty) :
this(id, grade, topic, text, difficulty, null, null, null, false, null, false, null)
		{
		}


		public String[] getMultChoices()
		{
			return multChoices;
		}

		public void setMultChoices(string[] multChoices)
		{
			this.multChoices = multChoices;
		}
		public bool getIsTheory()
		{
			return isTheory;
		}


		public void setIsTheory(bool isTheory)
		{
			this.isTheory = isTheory;
		}
		public string getAnswer()
		{
			return Answer;
		}


		public void setAnswer(string answer)
		{
			this.Answer= answer;
		}
		public bool getIsMultChoice()
		{
			return isMultChoice;
		}


		public void setIsMultChoice(bool isMultChoice)
		{
			this.isMultChoice = isMultChoice;
		}
		public int getId() {
			return id;
		}


		public void setId(int id) {
			this.id = id;
		}


		public String getText() {
			return text;
		}


		public void setText(String text) {
			this.text = text;
		}


		public int getGrade() {
			return grade;
		}


		public void setGrade(int grade) {
			this.grade = grade;
		}


		public String getTopic() {
			return topic;
		}


		public void setTopic(String topic) {
			this.topic = topic;
		}

		public String getSubTopic()
		{
			return subTopic;
		}

		public void setSubTopic(String subTopic)
		{
			this.subTopic = subTopic;
		}

		public String[] getOperatorStacks()
		{
			return operatorStacks;
		}


		public void setOperatorStacks(String[] operatorStacks)
		{
			this.operatorStacks = operatorStacks;
		}
		public String[] getVarStacks()
		{
			return varStacks;
		}


		public void setvarStacks(String[] varStacks)
		{
			this.varStacks = varStacks;
		}

		public int getDifficulty() {
			return difficulty;
		}


		public void setDifficulty(int difficulty) {
			this.difficulty = difficulty;
		}


		public String[] getEquation() {
			return equations;
		}


		public void setEquation(String[] equation) {
			this.equations = equation;
		}
        public String[] getImagePaths()
        {
            return imagePaths;
        }
        public void setImagePaths(String[] imagePaths)
        {
            this.imagePaths = imagePaths;
        }


        public String getImagePathsAsString()
        {
            return String.Join(";",imagePaths);
        }
        public void setImagePathsFromString(String imagePaths)
        {
            this.imagePaths = imagePaths.Split(';') ;
        }


        public String toString(){

			return id + " " + grade + " " + topic + " " + text + " " + difficulty + " " + equations;
		}

		public Boolean Equals(Uzdevums uzdevums)
		{
			if (this.id!=0 && this.id == uzdevums.id)
				return true;


			if (this.grade == uzdevums.grade &&
				this.difficulty == uzdevums.difficulty &&
				this.text.Equals(uzdevums.text))
				return true;


			return false;

		}


		public String getEquationAsString()
		{try
			{
				if (equations == null)
					return null;
				String equation = null;
				foreach (String i in equations)
				{
					equation += i + ';';
				}
				return equation.Substring(0, equation.Length - 1);
			}
			catch
			{
				return null;
			}
		}


		public String getVarStacksAsString()
		{
			try
			{
				if (varStacks == null)
					return null;
				String varStack = null;
				foreach (String i in varStacks)
				{
					varStack += i + ';';
				}
				return varStack.Substring(0, varStack.Length - 1);
			}
			catch
			{
				return null;
			}
		}


		public String getOperatorStacksAsString()
		{
			try
			{
				if (operatorStacks == null)
					return null;
				String operatorStack = null;
				foreach (String i in operatorStacks)
				{
					operatorStack += i + ';';
				}
				return operatorStack.Substring(0, operatorStack.Length - 1);
			}
			catch
			{
				return null;
			}

		}

		public String getMultChoicesAsString()
		{
			if (multChoices == null)
				return null;
			String multChoice = null;
			foreach (String i in multChoices)
			{
				multChoice += i + ';';
			}
			return multChoice.Substring(0, multChoice.Length - 1);
		}

		public void parseEquation(String equation)
		{
			try
			{
				this.equations = equation.Split(';');
			}
			catch (NullReferenceException e)
			{
				this.equations = null;
			}
		}


		public void parseVarStacks(String varStacks)
		{
			try
			{
				this.varStacks = varStacks.Split(';');
			}
			catch (NullReferenceException e)
			{
				this.varStacks = null;
			}
		}


		public void parseOperatorStacks(String operatorStacks)
		{
			try
			{
				this.operatorStacks = operatorStacks.Split(';');
			}
			catch (NullReferenceException e)
			{
				this.operatorStacks = null;
			}

		}

		public void parseMultChoices(String multChoices)
		{
			try
			{
				this.multChoices = multChoices.Split(';');
				isMultChoice = true;
			}
			catch (NullReferenceException e)
			{
				this.multChoices = null;
			}
		}

	}
}

