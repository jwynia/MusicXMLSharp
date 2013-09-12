/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Transpose {
    
    private string diatonicField;
    
    private decimal chromaticField;
    
    private string octavechangeField;
    
    private Empty doubleField;
    
    private string numberField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string diatonic {
        get {
            return this.diatonicField;
        }
        set {
            this.diatonicField = value;
        }
    }
    
    /// <remarks/>
    public decimal chromatic {
        get {
            return this.chromaticField;
        }
        set {
            this.chromaticField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("octave-change", DataType="integer")]
    public string octavechange {
        get {
            return this.octavechangeField;
        }
        set {
            this.octavechangeField = value;
        }
    }
    
    /// <remarks/>
    public Empty @double {
        get {
            return this.doubleField;
        }
        set {
            this.doubleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
    public string number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
        }
    }
}