/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Degree {
    
    private DegreeValue _degreeValueField;
    
    private DegreeAlter _degreeAlterField;
    
    private DegreeType _degreeTypeField;
    
    private YesNo printobjectField;
    
    private bool printobjectFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("degree-value")]
    public DegreeValue DegreeValue {
        get {
            return this._degreeValueField;
        }
        set {
            this._degreeValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("degree-alter")]
    public DegreeAlter DegreeAlter {
        get {
            return this._degreeAlterField;
        }
        set {
            this._degreeAlterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("degree-type")]
    public DegreeType DegreeType {
        get {
            return this._degreeTypeField;
        }
        set {
            this._degreeTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
    public YesNo printobject {
        get {
            return this.printobjectField;
        }
        set {
            this.printobjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool printobjectSpecified {
        get {
            return this.printobjectFieldSpecified;
        }
        set {
            this.printobjectFieldSpecified = value;
        }
    }
}