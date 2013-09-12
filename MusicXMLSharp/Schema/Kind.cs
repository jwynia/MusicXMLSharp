/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Kind {
    
    private YesNo usesymbolsField;
    
    private bool usesymbolsFieldSpecified;
    
    private string textField;
    
    private YesNo stackdegreesField;
    
    private bool stackdegreesFieldSpecified;
    
    private YesNo parenthesesdegreesField;
    
    private bool parenthesesdegreesFieldSpecified;
    
    private YesNo bracketdegreesField;
    
    private bool bracketdegreesFieldSpecified;
    
    private LeftCenterRight halignField;
    
    private bool halignFieldSpecified;
    
    private VAlign _vAlignField;
    
    private bool valignFieldSpecified;
    
    private KindValue valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("use-symbols")]
    public YesNo usesymbols {
        get {
            return this.usesymbolsField;
        }
        set {
            this.usesymbolsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool usesymbolsSpecified {
        get {
            return this.usesymbolsFieldSpecified;
        }
        set {
            this.usesymbolsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("stack-degrees")]
    public YesNo stackdegrees {
        get {
            return this.stackdegreesField;
        }
        set {
            this.stackdegreesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool stackdegreesSpecified {
        get {
            return this.stackdegreesFieldSpecified;
        }
        set {
            this.stackdegreesFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("parentheses-degrees")]
    public YesNo parenthesesdegrees {
        get {
            return this.parenthesesdegreesField;
        }
        set {
            this.parenthesesdegreesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool parenthesesdegreesSpecified {
        get {
            return this.parenthesesdegreesFieldSpecified;
        }
        set {
            this.parenthesesdegreesFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("bracket-degrees")]
    public YesNo bracketdegrees {
        get {
            return this.bracketdegreesField;
        }
        set {
            this.bracketdegreesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool bracketdegreesSpecified {
        get {
            return this.bracketdegreesFieldSpecified;
        }
        set {
            this.bracketdegreesFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LeftCenterRight halign {
        get {
            return this.halignField;
        }
        set {
            this.halignField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool halignSpecified {
        get {
            return this.halignFieldSpecified;
        }
        set {
            this.halignFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public VAlign VAlign {
        get {
            return this._vAlignField;
        }
        set {
            this._vAlignField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valignSpecified {
        get {
            return this.valignFieldSpecified;
        }
        set {
            this.valignFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public KindValue Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}