namespace apprentice_bootcamp_fundamentals_2 {
  using System;

  public class Receipt {
    private string _text = String.Empty;
        public int _total { get; set; }
        private int _numberOfA;
    private int _numberOfB;

    public string Text {
      get => $"{this._text}Total: {this._total}";
    }

    public void ScannedA() {
      this._text = $"{this._text}A: 50";
      this._numberOfA++;
      if (this._numberOfA % 5 == 0) {
        this._text = $"{this._text} - 30 (5 for 220)";
      }
      this._text = $"{this._text}\n";
    }

    public void ScannedB() {
      this._text = $"{this._text}B: 30";
      this._numberOfB++;
      if (this._numberOfB % 2 == 0) {
        this._text = $"{this._text} - 15 (2 for 45)";
      }
      this._text = $"{this._text}\n";
    }

    public void ScannedC() {
      this._text = $"{this._text}C: 20\n";
    }

    public void ScannedD() {
      this._text = $"{this._text}D: 15\n";

    }
  }
}