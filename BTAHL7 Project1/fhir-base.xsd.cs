namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.xml", typeof(global::BTAHL7Schemas.xml))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.fhir_xhtml", typeof(global::BTAHL7Schemas.fhir_xhtml))]
    public sealed class fhir_base : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:xhtml=""http://www.w3.org/1999/xhtml"" xmlns=""http://hl7.org/fhir"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://hl7.org/fhir"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BTAHL7Schemas.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:import schemaLocation=""BTAHL7Schemas.fhir_xhtml"" namespace=""http://www.w3.org/1999/xhtml"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://www.w3.org/1999/xhtml"" />
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:simpleType name=""date-primitive"">
    <xs:restriction>
      <xs:simpleType>
        <xs:union memberTypes=""xs:gYear xs:gYearMonth xs:date"" />
      </xs:simpleType>
      <xs:pattern value=""([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)(-(0[1-9]|1[0-2])(-(0[0-9]|[1-2][0-9]|3[0-1]))?)?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""date"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A date or partial date (e.g. just year or year + month). There is no time zone. The format is a union of the schema types gYear, gYearMonth and date.  Dates SHALL be valid dates.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""date-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""dateTime-primitive"">
    <xs:restriction>
      <xs:simpleType>
        <xs:union memberTypes=""xs:gYear xs:gYearMonth xs:date xs:dateTime"" />
      </xs:simpleType>
      <xs:pattern value=""([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)(-(0[1-9]|1[0-2])(-(0[0-9]|[1-2][0-9]|3[0-1])(T([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]+)?(Z|(\+|-)((0[0-9]|1[0-3]):[0-5][0-9]|14:00)))?)?)?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""dateTime"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A date, date-time or partial date (e.g. just year or year + month).  If hours and minutes are specified, a time zone SHALL be populated. The format is a union of the schema types gYear, gYearMonth, date and dateTime. Seconds must be provided due to schema type constraints but may be zero-filled and may be ignored.                 Dates SHALL be valid dates.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""dateTime-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""code-primitive"">
    <xs:restriction base=""xs:token"">
      <xs:minLength value=""1"" />
      <xs:pattern value=""[^\s]+(\s[^\s]+)*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""code"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A string which has at least one character and no leading or trailing whitespace and where there is no whitespace other than single spaces in the contents</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""code-primitive"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""string-primitive"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""string"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A sequence of Unicode characters</xs:documentation>
      <xs:documentation xml:lang=""en"">Note that FHIR strings SHALL NOT exceed 1MB in size</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""string-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""integer-primitive"">
    <xs:restriction base=""xs:int"">
      <xs:pattern value=""-?([0]|([1-9][0-9]*))"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""integer"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A whole number</xs:documentation>
      <xs:documentation xml:lang=""en"">32 bit number; for values larger than this, use decimal</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""integer-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""oid-primitive"">
    <xs:restriction base=""xs:anyURI"">
      <xs:pattern value=""urn:oid:[0-2](\.(0|[1-9][0-9]*))+"" />
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""oid"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">An OID represented as a URI</xs:documentation>
      <xs:documentation xml:lang=""en"">RFC 3001. See also ISO/IEC 8824:1990 €</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""oid-primitive"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""canonical-primitive"">
    <xs:restriction base=""xs:anyURI"">
      <xs:pattern value=""\S*"" />
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""canonical"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A URI that is a reference to a canonical URL on a FHIR resource</xs:documentation>
      <xs:documentation xml:lang=""en"">see [Canonical References](references.html#canonical)</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""canonical-primitive"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""uri-primitive"">
    <xs:restriction base=""xs:anyURI"">
      <xs:pattern value=""\S*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""uri"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">String of characters used to identify a name or a resource</xs:documentation>
      <xs:documentation xml:lang=""en"">see http://en.wikipedia.org/wiki/Uniform_resource_identifier</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""uri-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""uuid-primitive"">
    <xs:restriction base=""xs:anyURI"">
      <xs:pattern value=""urn:uuid:[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}"" />
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""uuid"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A UUID, represented as a URI</xs:documentation>
      <xs:documentation xml:lang=""en"">See The Open Group, CDE 1.1 Remote Procedure Call specification, Appendix A.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""uuid-primitive"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""url-primitive"">
    <xs:restriction base=""xs:anyURI"">
      <xs:pattern value=""\S*"" />
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""url"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A URI that is a literal reference</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""url-primitive"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""instant-primitive"">
    <xs:restriction base=""xs:dateTime"">
      <xs:pattern value=""([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])T([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]+)?(Z|(\+|-)((0[0-9]|1[0-3]):[0-5][0-9]|14:00))"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""instant"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">An instant in time - known at least to the second</xs:documentation>
      <xs:documentation xml:lang=""en"">Note: This is intended for where precisely observed times are required, typically system logs etc., and not human-reported times - for them, see date and dateTime (which can be as precise as instant, but is not required to be) below. Time zone is always required</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""instant-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""boolean-primitive"">
    <xs:restriction base=""xs:boolean"">
      <xs:pattern value=""true|false"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""boolean"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Value of ""true"" or ""false""</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""boolean-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""base64Binary-primitive"">
    <xs:restriction base=""xs:base64Binary"">
      <xs:pattern value=""(\s*([0-9a-zA-Z\+/=]){4}\s*)+"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""base64Binary"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A stream of bytes</xs:documentation>
      <xs:documentation xml:lang=""en"">A stream of bytes, base64 encoded</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""base64Binary-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""unsignedInt-primitive"">
    <xs:restriction base=""xs:nonNegativeInteger"">
      <xs:pattern value=""[0]|([1-9][0-9]*)"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""unsignedInt"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">An integer with a value that is not negative (e.g. &gt;= 0)</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""unsignedInt-primitive"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""markdown-primitive"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""1"" />
      <xs:pattern value=""[ \r\n\t\S]+"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""markdown"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A string that may contain Github Flavored Markdown syntax for optional processing by a mark down presentation engine</xs:documentation>
      <xs:documentation xml:lang=""en"">Systems are not required to have markdown support, so the text should be readable without markdown processing. The markdown syntax is GFM - see https://github.github.com/gfm/</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""markdown-primitive"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""time-primitive"">
    <xs:restriction base=""xs:time"">
      <xs:pattern value=""([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]+)?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""time"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A time during the day, with no date specified</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""time-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""id-primitive"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[A-Za-z0-9\-\.]{1,64}"" />
      <xs:minLength value=""1"" />
      <xs:maxLength value=""64"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""id"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Any combination of letters, numerals, ""-"" and ""."", with a length limit of 64 characters.  (This might be an integer, an unprefixed OID, UUID or any other identifier pattern that meets these constraints.)  Ids are case-insensitive.</xs:documentation>
      <xs:documentation xml:lang=""en"">RFC 4122</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""id-primitive"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""positiveInt-primitive"">
    <xs:restriction base=""xs:positiveInteger"">
      <xs:pattern value=""[1-9][0-9]*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""positiveInt"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">An integer with a value that is positive (e.g. &gt;0)</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""positiveInt-primitive"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""decimal-primitive"">
    <xs:union memberTypes=""xs:decimal xs:double"" />
  </xs:simpleType>
  <xs:complexType name=""decimal"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A rational number with implicit precision</xs:documentation>
      <xs:documentation xml:lang=""en"">Do not use an IEEE type floating point type, instead use something that works like a true decimal, with inbuilt precision (e.g. Java BigInteger)</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""decimal-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ResourceContainer"">
    <xs:sequence>
      <xs:any processContents=""lax"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""Extension"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Optional Extension Element - found in all resources.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</xs:documentation>
            </xs:annotation>
            <xs:element name=""valueBase64Binary"" type=""base64Binary"" />
            <xs:element name=""valueBoolean"" type=""boolean"" />
            <xs:element name=""valueCanonical"" type=""canonical"" />
            <xs:element name=""valueCode"" type=""code"" />
            <xs:element name=""valueDate"" type=""date"" />
            <xs:element name=""valueDateTime"" type=""dateTime"" />
            <xs:element name=""valueDecimal"" type=""decimal"" />
            <xs:element name=""valueId"" type=""id"" />
            <xs:element name=""valueInstant"" type=""instant"" />
            <xs:element name=""valueInteger"" type=""integer"" />
            <xs:element name=""valueMarkdown"" type=""markdown"" />
            <xs:element name=""valueOid"" type=""oid"" />
            <xs:element name=""valuePositiveInt"" type=""positiveInt"" />
            <xs:element name=""valueString"" type=""string"" />
            <xs:element name=""valueTime"" type=""time"" />
            <xs:element name=""valueUnsignedInt"" type=""unsignedInt"" />
            <xs:element name=""valueUri"" type=""uri"" />
            <xs:element name=""valueUrl"" type=""url"" />
            <xs:element name=""valueUuid"" type=""uuid"" />
            <xs:element name=""valueAddress"" type=""Address"" />
            <xs:element name=""valueAge"" type=""Age"" />
            <xs:element name=""valueAnnotation"" type=""Annotation"" />
            <xs:element name=""valueAttachment"" type=""Attachment"" />
            <xs:element name=""valueCodeableConcept"" type=""CodeableConcept"" />
            <xs:element name=""valueCoding"" type=""Coding"" />
            <xs:element name=""valueContactPoint"" type=""ContactPoint"" />
            <xs:element name=""valueCount"" type=""Count"" />
            <xs:element name=""valueDistance"" type=""Distance"" />
            <xs:element name=""valueDuration"" type=""Duration"" />
            <xs:element name=""valueHumanName"" type=""HumanName"" />
            <xs:element name=""valueIdentifier"" type=""Identifier"" />
            <xs:element name=""valueMoney"" type=""Money"" />
            <xs:element name=""valuePeriod"" type=""Period"" />
            <xs:element name=""valueQuantity"" type=""Quantity"" />
            <xs:element name=""valueRange"" type=""Range"" />
            <xs:element name=""valueRatio"" type=""Ratio"" />
            <xs:element name=""valueReference"" type=""Reference"" />
            <xs:element name=""valueSampledData"" type=""SampledData"" />
            <xs:element name=""valueSignature"" type=""Signature"" />
            <xs:element name=""valueTiming"" type=""Timing"" />
            <xs:element name=""valueContactDetail"" type=""ContactDetail"" />
            <xs:element name=""valueContributor"" type=""Contributor"" />
            <xs:element name=""valueDataRequirement"" type=""DataRequirement"" />
            <xs:element name=""valueExpression"" type=""Expression"" />
            <xs:element name=""valueParameterDefinition"" type=""ParameterDefinition"" />
            <xs:element name=""valueRelatedArtifact"" type=""RelatedArtifact"" />
            <xs:element name=""valueTriggerDefinition"" type=""TriggerDefinition"" />
            <xs:element name=""valueUsageContext"" type=""UsageContext"" />
            <xs:element name=""valueDosage"" type=""Dosage"" />
            <xs:element name=""valueMeta"" type=""Meta"" />
          </xs:choice>
        </xs:sequence>
        <xs:attribute name=""url"" type=""uri-primitive"" use=""required"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""BackboneElement"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Base definition for all elements that are defined inside a resource - but not those in a data type.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""modifierExtension"" type=""Extension"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
								Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Narrative"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A human-readable summary of the resource conveying the essential clinical and business information for the resource.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""status"" type=""NarrativeStatus"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The status of the narrative - whether it's entirely generated (from just the defined data or the extensions too), or whether a human authored it and it may contain additional data.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""xhtml:div"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The actual narrative content, a stripped down version of XHTML.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NarrativeStatus-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""generated"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Generated</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""extensions"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Extensions</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""additional"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Additional</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""empty"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Empty</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""NarrativeStatus"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The status of a resource narrative.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""NarrativeStatus-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Element"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Base definition for all elements in a resource.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""extension"" type=""Extension"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute name=""id"" type=""string-primitive"" use=""optional"" />
  </xs:complexType>
  <xs:complexType name=""Meta"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The metadata about a resource. This is content in the resource that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""versionId"" type=""id"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The version specific identifier, as it appears in the version portion of the URL. This value changes when the resource is created, updated, or deleted.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""lastUpdated"" type=""instant"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">When the resource last changed - e.g. when the version changed.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""source"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A uri that identifies the source system of the resource. This provides a minimal amount of [[[Provenance]]] information that can be used to track or differentiate the source of information in the resource. The source may identify another FHIR server, document, message, database, etc.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""profile"" type=""canonical"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A list of profiles (references to [[[StructureDefinition]]] resources) that this resource claims to conform to. The URL is a reference to [[[StructureDefinition.url]]].</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""security"" type=""Coding"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Security labels applied to this resource. These tags connect specific resources to the overall security policy and infrastructure.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""tag"" type=""Coding"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Tags applied to this resource. Tags are intended to be used to identify and relate resources to process and workflow, and applications are not required to consider the tags when interpreting the meaning of a resource.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Address"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">An address expressed using postal conventions (as opposed to GPS or other location definition formats).  This data type may be used to convey addresses for use in delivering mail as well as for visiting locations which might not be valid for mail delivery.  There are a variety of postal address formats defined around the world.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""use"" type=""AddressUse"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The purpose of this address.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""type"" type=""AddressType"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Distinguishes between physical addresses (those you can visit) and mailing addresses (e.g. PO Boxes and care-of addresses). Most addresses are both.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""text"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Specifies the entire address as it should be displayed e.g. on a postal label. This may be provided instead of or as well as the specific parts.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""line"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">This component contains the house number, apartment number, street name, street direction,  P.O. Box number, delivery hints, and similar address information.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""city"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The name of the city, town, suburb, village or other community or delivery center.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""district"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The name of the administrative area (county).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""state"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Sub-unit of a country with limited sovereignty in a federally organized country. A code may be used if codes are in common use (e.g. US 2 letter state codes).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""postalCode"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A postal code designating a region defined by the postal service.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""country"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Country - a nation as commonly understood or generally accepted.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""period"" type=""Period"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Time period when address was/is in use.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""AddressUse-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""home"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Home</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""work"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Work</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""temp"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Temporary</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""old"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Old / Incorrect</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""billing"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Billing</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""AddressUse"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The use of an address.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""AddressUse-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""AddressType-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""postal"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Postal</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""physical"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Physical</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""both"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Postal &amp; Physical</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""AddressType"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The type of an address (physical / postal).</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""AddressType-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Contributor"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A contributor to the content of a knowledge asset, including authors, editors, reviewers, and endorsers.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""type"" type=""ContributorType"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The type of contributor.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""name"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The name of the individual or organization responsible for the contribution.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""contact"" type=""ContactDetail"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Contact details to assist a user in finding and communicating with the contributor.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""ContributorType-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""author"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Author</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""editor"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Editor</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""reviewer"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Reviewer</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""endorser"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Endorser</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ContributorType"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The type of contributor.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""ContributorType-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Attachment"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">For referring to data content defined in other formats.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""contentType"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies the type of the data in the attachment and allows a method to be chosen to interpret or render the data. Includes mime type parameters such as charset where appropriate.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""language"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The human language of the content. The value can be any valid value according to BCP 47.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""data"" type=""base64Binary"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The actual data of the attachment - a sequence of bytes, base64 encoded.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""url"" type=""url"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A location where the data can be accessed.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""size"" type=""unsignedInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The number of bytes of data that make up this attachment (before base64 encoding, if that is done).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""hash"" type=""base64Binary"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The calculated hash of the data using SHA-1. Represented using base64.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""title"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A label or set of text to display in place of the data.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""creation"" type=""dateTime"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The date that the attachment was first created.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Count"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Quantity"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""DataRequirement"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""type"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The type of the required data, specified as the type name of a resource. For profiles, this value is set to the type of the base resource of the profile.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""profile"" type=""canonical"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The profile of the required data, specified as the uri of the profile definition.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The intended subjects of the data requirement. If this element is not provided, a Patient subject is assumed.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""subjectCodeableConcept"" type=""CodeableConcept"" />
            <xs:element maxOccurs=""1"" name=""subjectReference"" type=""Reference"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""mustSupport"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates that specific elements of the type are referenced by the knowledge module and must be supported by the consumer in order to obtain an effective evaluation. This does not mean that a value is required for this element, only that the consuming system must understand the element and be able to provide values for it if they are available.
								The value of mustSupport SHALL be a FHIRPath resolveable on the type of the DataRequirement. The path SHALL consist only of identifiers, constant indexers, and .resolve() (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""codeFilter"" type=""DataRequirement.CodeFilter"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data. Each code filter defines an additional constraint on the data, i.e. code filters are AND'ed, not OR'ed.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""dateFilter"" type=""DataRequirement.DateFilter"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Date filters specify additional constraints on the data in terms of the applicable date range for specific elements. Each date filter specifies an additional constraint on the data, i.e. date filters are AND'ed, not OR'ed.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""limit"" type=""positiveInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Specifies a maximum number of results that are required (uses the _count search parameter).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""sort"" type=""DataRequirement.Sort"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Specifies the order of the results to be returned.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""DataRequirement.CodeFilter"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""path"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The code-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type code, Coding, or CodeableConcept.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""searchParam"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A token parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type code, Coding, or CodeableConcept.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""valueSet"" type=""canonical"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The valueset for the code filter. The valueSet and code elements are additive. If valueSet is specified, the filter will return only those data items for which the value of the code-valued element specified in the path is a member of the specified valueset.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""code"" type=""Coding"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The codes for the code filter. If values are given, the filter will return only those data items for which the code-valued attribute specified by the path has a value that is one of the specified codes. If codes are specified in addition to a value set, the filter returns items matching a code in the value set or one of the specified codes.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""DataRequirement.DateFilter"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""path"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The date-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type date, dateTime, Period, Schedule, or Timing.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""searchParam"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A date parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type date, dateTime, Period, Schedule, or Timing.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""valueDateTime"" type=""dateTime"" />
            <xs:element maxOccurs=""1"" name=""valuePeriod"" type=""Period"" />
            <xs:element maxOccurs=""1"" name=""valueDuration"" type=""Duration"" />
          </xs:choice>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""DataRequirement.Sort"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""path"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The attribute of the sort. The specified path must be resolvable from the type of the required data. The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements. Note that the index must be an integer constant.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""direction"" type=""SortDirection"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The direction of the sort, ascending or descending.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""SortDirection-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""ascending"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Ascending</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""descending"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Descending</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""SortDirection"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The possible sort directions, ascending or descending.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""SortDirection-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Dosage"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Indicates how the medication is/was taken or should be taken by the patient.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""sequence"" type=""integer"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates the order in which the dosage instructions should be applied or interpreted.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""text"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Free text dosage instructions e.g. SIG.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""additionalInstruction"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Supplemental instructions to the patient on how to take the medication  (e.g. ""with meals"" or""take half to one hour before food"") or warnings for the patient about the medication (e.g. ""may cause drowsiness"" or ""avoid exposure of skin to direct sunlight or sunlamps"").</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""patientInstruction"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Instructions in terms that are understood by the patient or consumer.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""timing"" type=""Timing"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">When medication should be administered.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates whether the Medication is only taken when needed within a specific dosing schedule (Boolean option), or it indicates the precondition for taking the Medication (CodeableConcept).</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""asNeededBoolean"" type=""boolean"" />
            <xs:element maxOccurs=""1"" name=""asNeededCodeableConcept"" type=""CodeableConcept"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""site"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Body site to administer to.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""route"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">How drug should enter body.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""method"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Technique for administering medication.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""doseAndRate"" type=""Dosage.DoseAndRate"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The amount of medication administered.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxDosePerPeriod"" type=""Ratio"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Upper limit on medication per unit of time.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxDosePerAdministration"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Upper limit on medication per administration.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxDosePerLifetime"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Upper limit on medication per lifetime of the patient.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Dosage.DoseAndRate"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Indicates how the medication is/was taken or should be taken by the patient.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""type"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The kind of dose or rate specified, for example, ordered or calculated.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Amount of medication per dose.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""doseRange"" type=""Range"" />
            <xs:element maxOccurs=""1"" name=""doseQuantity"" type=""Quantity"" />
          </xs:choice>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Amount of medication per unit of time.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""rateRatio"" type=""Ratio"" />
            <xs:element maxOccurs=""1"" name=""rateRange"" type=""Range"" />
            <xs:element maxOccurs=""1"" name=""rateQuantity"" type=""Quantity"" />
          </xs:choice>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Money"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">An amount of economic utility in some recognized currency.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""value"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Numerical value (with implicit precision).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""currency"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">ISO 4217 Currency Code.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""HumanName"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A human's name with the ability to identify parts and usage.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""use"" type=""NameUse"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies the purpose for this name.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""text"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Specifies the entire name as it should be displayed e.g. on an application UI. This may be provided instead of or as well as the specific parts.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""family"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The part of a name that links to the genealogy. In some cultures (e.g. Eritrea) the family name of a son is the first name of his father.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""given"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Given name.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""prefix"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the start of the name.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""suffix"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the end of the name.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""period"" type=""Period"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates the period of time when this name was valid for the named person.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NameUse-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""usual"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Usual</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""official"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Official</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""temp"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Temp</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""nickname"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Nickname</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""anonymous"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Anonymous</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""old"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Old</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""maiden"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Name changed for Marriage</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""NameUse"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The use of a human name.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""NameUse-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ContactPoint"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Details for all kinds of technology mediated contact points for a person or organization, including telephone, email, etc.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""system"" type=""ContactPointSystem"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Telecommunications form for contact point - what communications system is required to make use of the contact.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""value"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The actual contact point details, in a form that is meaningful to the designated communication system (i.e. phone number or email address).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""use"" type=""ContactPointUse"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies the purpose for the contact point.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""rank"" type=""positiveInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Specifies a preferred order in which to use a set of contacts. ContactPoints with lower rank values are more preferred than those with higher rank values.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""period"" type=""Period"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Time period when the contact point was/is in use.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""ContactPointSystem-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""phone"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Phone</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""fax"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Fax</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""email"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Email</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""pager"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Pager</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""url"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">URL</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""sms"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">SMS</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""other"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Other</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ContactPointSystem"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Telecommunications form for contact point.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""ContactPointSystem-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""ContactPointUse-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""home"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Home</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""work"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Work</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""temp"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Temp</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""old"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Old</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""mobile"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Mobile</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ContactPointUse"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Use of contact point.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""ContactPointUse-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""MarketingStatus"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""country"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The country in which the marketing authorisation has been granted shall be specified It should be specified using the ISO 3166 ‑ 1 alpha-2 code elements.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""jurisdiction"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where a Medicines Regulatory Agency has granted a marketing authorisation for which specific provisions within a jurisdiction apply, the jurisdiction can be specified using an appropriate controlled terminology The controlled term and the controlled term identifier shall be specified.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""status"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">This attribute provides information on the status of the marketing of the medicinal product See ISO/TS 20443 for more information and examples.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""dateRange"" type=""Period"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""restoreDate"" type=""dateTime"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Identifier"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">An identifier - identifies some entity uniquely and unambiguously. Typically this is used for business identifiers.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""use"" type=""IdentifierUse"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The purpose of this identifier.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""type"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A coded type for the identifier that can be used to determine which identifier to use for a specific purpose.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""system"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Establishes the namespace for the value - that is, a URL that describes a set values that are unique.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""value"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The portion of the identifier typically relevant to the user and which is unique within the context of the system.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""period"" type=""Period"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Time period during which identifier is/was valid for use.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""assigner"" type=""Reference"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Organization that issued/manages the identifier.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""IdentifierUse-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""usual"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Usual</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""official"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Official</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""temp"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Temp</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""secondary"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Secondary</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""old"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Old</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""IdentifierUse"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Identifies the purpose for this identifier, if known .</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""IdentifierUse-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""SubstanceAmount"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Chemical substances are a single substance type whose primary defining element is the molecular structure. Chemical substances shall be defined on the basis of their complete covalent molecular structure; the presence of a salt (counter-ion) and/or solvates (water, alcohols) is also captured. Purity, grade, physical form or particle size are not taken into account in the definition of a chemical substance or in the assignment of a Substance ID.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""amountQuantity"" type=""Quantity"" />
            <xs:element maxOccurs=""1"" name=""amountRange"" type=""Range"" />
            <xs:element maxOccurs=""1"" name=""amountString"" type=""string"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""amountType"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Most elements that require a quantitative value will also have a field called amount type. Amount type should always be specified because the actual value of the amount is often dependent on it. EXAMPLE: In capturing the actual relative amounts of substances or molecular fragments it is essential to indicate whether the amount refers to a mole ratio or weight ratio. For any given element an effort should be made to use same the amount type for all related definitional elements.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""amountText"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A textual comment on a numeric value.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""referenceRange"" type=""SubstanceAmount.ReferenceRange"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Reference range of possible or expected values.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""SubstanceAmount.ReferenceRange"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Chemical substances are a single substance type whose primary defining element is the molecular structure. Chemical substances shall be defined on the basis of their complete covalent molecular structure; the presence of a salt (counter-ion) and/or solvates (water, alcohols) is also captured. Purity, grade, physical form or particle size are not taken into account in the definition of a chemical substance or in the assignment of a Substance ID.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""lowLimit"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Lower limit possible or expected.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""highLimit"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Upper limit possible or expected.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Coding"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A reference to a code defined by a terminology system.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""system"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The identification of the code system that defines the meaning of the symbol in the code.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""version"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The version of the code system which was used when choosing this code. Note that a well-maintained code system does not need the version reported, because the meaning of codes is consistent across versions. However this cannot consistently be assured, and when the meaning is not guaranteed to be consistent, the version SHOULD be exchanged.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""code"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A symbol in syntax defined by the system. The symbol may be a predefined code or an expression in a syntax defined by the coding system (e.g. post-coordination).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""display"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A representation of the meaning of the code in the system, following the rules of the system.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""userSelected"" type=""boolean"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates that this coding was chosen by a user directly - e.g. off a pick list of available items (codes or displays).</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""SampledData"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A series of measurements taken by a device, with upper and lower limits. There may be more than one dimension in the data.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""origin"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The base quantity that a measured value of zero represents. In addition, this provides the units of the entire measurement series.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""period"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The length of time between sampling times, measured in milliseconds.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""factor"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A correction factor that is applied to the sampled data points before they are added to the origin.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""lowerLimit"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The lower limit of detection of the measured points. This is needed if any of the data points have the value ""L"" (lower than detection limit).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""upperLimit"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The upper limit of detection of the measured points. This is needed if any of the data points have the value ""U"" (higher than detection limit).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""dimensions"" type=""positiveInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The number of sample points at each time point. If this value is greater than one, then the dimensions will be interlaced - all the sample points for a point in time will be recorded at once.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""data"" type=""SampledDataDataType"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A series of data points which are decimal values separated by a single space (character u20). The special values ""E"" (error), ""L"" (below detection limit) and ""U"" (above detection limit) can also be used in place of a decimal value.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""SampledDataDataType-primitive"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""((-{0,1}\d*\.{0,1}\d+)|[EUL])( ((-{0,1}\d*\.{0,1}\d+)|[EUL]))*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""SampledDataDataType"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""SampledDataDataType-primitive"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Population"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A populatioof people with some set of grouping criteria.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The age of the specific population.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""ageRange"" type=""Range"" />
            <xs:element maxOccurs=""1"" name=""ageCodeableConcept"" type=""CodeableConcept"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""gender"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The gender of the specific population.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""race"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Race of the specific population.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""physiologicalCondition"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The existing physiological conditions of the specific population to which this applies.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Ratio"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A relationship of two Quantity values - expressed as a numerator and a denominator.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""numerator"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The value of the numerator.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""denominator"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The value of the denominator.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Distance"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A length - a value with a unit that is a physical distance.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Quantity"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Age"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A duration of time during which an organism (or a process) has existed.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Quantity"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Reference"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A reference from one resource to another.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""reference"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A reference to a location at which the other resource is found. The reference may be a relative reference, in which case it is relative to the service base URL, or an absolute URL that resolves to the location where the resource is found. The reference may be version specific or not. If the reference is not to a FHIR RESTful server, then it should be assumed to be version specific. Internal fragment references (start with '#') refer to contained resources.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""type"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The expected type of the target of the reference. If both Reference.type and Reference.reference are populated and Reference.reference is a FHIR URL, both SHALL be consistent.
								The type is the Canonical URL of Resource Definition that is the type this reference refers to. References are URLs that are relative to http://hl7.org/fhir/StructureDefinition/ e.g. ""Patient"" is a reference to http://hl7.org/fhir/StructureDefinition/Patient. Absolute URLs are only allowed for logical models (and can only be used in references in logical models, not resources).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""identifier"" type=""Identifier"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">An identifier for the target resource. This is used when there is no way to reference the other resource directly, either because the entity it represents is not available through a FHIR server, or because there is no way for the author of the resource to convert a known identifier to an actual location. There is no requirement that a Reference.identifier point to something that is actually exposed as a FHIR instance, but it SHALL point to a business concept that would be expected to be exposed as a FHIR instance, and that instance would need to be of a FHIR resource type allowed by the reference.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""display"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Plain text narrative that identifies the resource in addition to the resource reference.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""TriggerDefinition"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A description of a triggering event. Triggering events can be named events, data events, or periodic, as determined by the type element.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""type"" type=""TriggerType"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The type of triggering event.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A formal name for the event. This may be an absolute URI that identifies the event formally (e.g. from a trigger registry), or a simple relative URI that identifies the event in a local context.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The timing of the event (if this is a periodic trigger).</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""timingTiming"" type=""Timing"" />
            <xs:element maxOccurs=""1"" name=""timingReference"" type=""Reference"" />
            <xs:element maxOccurs=""1"" name=""timingDate"" type=""date"" />
            <xs:element maxOccurs=""1"" name=""timingDateTime"" type=""dateTime"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""data"" type=""DataRequirement"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The triggering data of the event (if this is a data trigger). If more than one data is requirement is specified, then all the data requirements must be true.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""condition"" type=""Expression"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A boolean-valued expression that is evaluated in the context of the container of the trigger definition and returns whether or not the trigger fires.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""TriggerType-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""named-event"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Named Event</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""periodic"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Periodic</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""data-changed"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Data Changed</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""data-added"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Data Added</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""data-modified"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Data Updated</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""data-removed"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Data Removed</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""data-accessed"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Data Accessed</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""data-access-ended"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Data Access Ended</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""TriggerType"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The type of trigger.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""TriggerType-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Quantity"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""value"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The value of the measured amount. The value includes an implicit precision in the presentation of the value.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""comparator"" type=""QuantityComparator"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is ""&lt;"" , then the real value is &lt; stated value.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""unit"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A human-readable form of the unit.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""system"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The identification of the system that provides the coded form of the unit.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""code"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A computer processable form of the unit in some unit representation system.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""QuantityComparator-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""&lt;"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Less than</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""&lt;="">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Less or Equal to</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""&gt;="">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Greater or Equal to</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""&gt;"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Greater than</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""QuantityComparator"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">How the Quantity should be understood and represented.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""QuantityComparator-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Period"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A time period defined by a start and end date and optionally time.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""start"" type=""dateTime"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The start of the period. The boundary is inclusive.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""end"" type=""dateTime"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The end of the period. If the end of the period is missing, it means no end was known or planned at the time the instance was created. The start may be in the past, and the end date in the future, which means that period is expected/planned to end at that time.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Duration"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A length of time.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Quantity"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Range"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A set of ordered Quantities defined by a low and high limit.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""low"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The low limit. The boundary is inclusive.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""high"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The high limit. The boundary is inclusive.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""RelatedArtifact"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Related artifacts such as additional documentation, justification, or bibliographic references.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""type"" type=""RelatedArtifactType"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The type of relationship to the related artifact.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""label"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A short label that can be used to reference the citation from elsewhere in the containing artifact, such as a footnote index.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""display"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A brief description of the document or knowledge resource being referenced, suitable for display to a consumer.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""citation"" type=""markdown"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A bibliographic citation for the related artifact. This text SHOULD be formatted according to an accepted citation format.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""url"" type=""url"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A url for the artifact that can be followed to access the actual content.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""document"" type=""Attachment"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The document being referenced, represented as an attachment. This is exclusive with the resource element.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""resource"" type=""canonical"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The related resource, such as a library, value set, profile, or other knowledge resource.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""RelatedArtifactType-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""documentation"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Documentation</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""justification"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Justification</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""citation"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Citation</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""predecessor"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Predecessor</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""successor"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Successor</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""derived-from"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Derived From</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""depends-on"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Depends On</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""composed-of"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Composed Of</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""RelatedArtifactType"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The type of relationship to the related artifact.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""RelatedArtifactType-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Annotation"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A  text note which also  contains information about who made the statement and when.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The individual responsible for making the annotation.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""authorReference"" type=""Reference"" />
            <xs:element maxOccurs=""1"" name=""authorString"" type=""string"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""time"" type=""dateTime"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates when this particular annotation was made.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""text"" type=""markdown"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The text of the annotation in markdown format.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ProductShelfLife"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The shelf-life and storage information for a medicinal product item or container can be described using this class.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""identifier"" type=""Identifier"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Unique identifier for the packaged Medicinal Product.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""type"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">This describes the shelf life, taking into account various scenarios such as shelf life of the packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life after the first opening of a bottle, etc. The shelf life type shall be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""period"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The shelf life time period can be specified using a numerical value for the period of time and its unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""specialPrecautionsForStorage"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ContactDetail"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Specifies contact information for a person or organization.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The name of an individual to contact.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""telecom"" type=""ContactPoint"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The contact details for the individual (if a name was provided) or the organization.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""UsageContext"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Specifies clinical/business/etc. metadata that can be used to retrieve, index and/or categorize an artifact. This metadata can either be specific to the applicable population (e.g., age category, DRG) or the specific context of care (e.g., venue, care setting, provider of care).</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""code"" type=""Coding"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A code that identifies the type of context being specified by this usage context.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""1"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A value that defines the context specified in this context of use. The interpretation of the value is defined by the code.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""valueCodeableConcept"" type=""CodeableConcept"" />
            <xs:element maxOccurs=""1"" name=""valueQuantity"" type=""Quantity"" />
            <xs:element maxOccurs=""1"" name=""valueRange"" type=""Range"" />
            <xs:element maxOccurs=""1"" name=""valueReference"" type=""Reference"" />
          </xs:choice>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Expression"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A expression that is evaluated in a specified context and returns a value. The context of use of the expression must specify the context in which the expression is evaluated, and how the result of the expression is used.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""description"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A brief, natural language description of the condition that effectively communicates the intended semantics.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""id"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A short name assigned to the expression to allow for multiple reuse of the expression in the context where it is defined.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""language"" type=""ExpressionLanguage"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The media type of the language for the expression.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""expression"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">An expression in the specified language that returns a value.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""reference"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A URI that defines where the expression is found.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""ExpressionLanguage-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""text/cql"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">CQL</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""text/fhirpath"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">FHIRPath</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""application/x-fhir-query"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">FHIR Query</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ExpressionLanguage"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The media type of the expression language.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""ExpressionLanguage-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Signature"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A signature along with supporting context. The signature may be a digital signature that is cryptographic in nature, or some other signature acceptable to the domain. This other signature may be as simple as a graphical image representing a hand-written signature, or a signature ceremony Different signature approaches have different utilities.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""type"" type=""Coding"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">An indication of the reason that the entity signed this document. This may be explicitly included as part of the signature information and can be used when determining accountability for various actions concerning the document.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""when"" type=""instant"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">When the digital signature was signed.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""who"" type=""Reference"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A reference to an application-usable description of the identity that signed  (e.g. the signature used their private key).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""onBehalfOf"" type=""Reference"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A reference to an application-usable description of the identity that is represented by the signature.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""targetFormat"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A mime type that indicates the technical format of the target resources signed by the signature.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""sigFormat"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A mime type that indicates the technical format of the signature. Important mime types are application/signature+xml for X ML DigSig, application/jose for JWS, and image/* for a graphical image of a signature, etc.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""data"" type=""base64Binary"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The base64 encoding of the Signature content. When signature is not recorded electronically this element would be empty.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Timing"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Specifies an event that may occur multiple times. Timing schedules are used to record when things are planned, expected or requested to occur. The most common usage is in dosage instructions for medications. They are also used when planning care of various kinds, and may be used for reporting the schedule to which past regular activities were carried out.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""event"" type=""dateTime"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies specific times when the event occurs.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""repeat"" type=""Timing.Repeat"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A set of rules that describe when the event is scheduled.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""code"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A code for the timing schedule (or just text in code.text). Some codes such as BID are ubiquitous, but many institutions define their own additional codes. If a code is provided, the code is understood to be a complete statement of whatever is specified in the structured timing data, and either the code or the data may be used to interpret the Timing, with the exception that .repeat.bounds still applies over the code (and is not contained in the code).</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Timing.Repeat"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Specifies an event that may occur multiple times. Timing schedules are used to record when things are planned, expected or requested to occur. The most common usage is in dosage instructions for medications. They are also used when planning care of various kinds, and may be used for reporting the schedule to which past regular activities were carried out.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Either a duration for the length of the timing schedule, a range of possible length, or outer bounds for start and/or end limits of the timing schedule.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""boundsDuration"" type=""Duration"" />
            <xs:element maxOccurs=""1"" name=""boundsRange"" type=""Range"" />
            <xs:element maxOccurs=""1"" name=""boundsPeriod"" type=""Period"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""count"" type=""positiveInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A total count of the desired number of repetitions across the duration of the entire timing specification. If countMax is present, this element indicates the lower bound of the allowed range of count values.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""countMax"" type=""positiveInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If present, indicates that the count is a range - so to perform the action between [count] and [countMax] times.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""duration"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">How long this thing happens for when it happens. If durationMax is present, this element indicates the lower bound of the allowed range of the duration.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""durationMax"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If present, indicates that the duration is a range - so to perform the action between [duration] and [durationMax] time length.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""durationUnit"" type=""UnitsOfTime"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The units of time for the duration, in UCUM units.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""frequency"" type=""positiveInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The number of times to repeat the action within the specified period. If frequencyMax is present, this element indicates the lower bound of the allowed range of the frequency.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""frequencyMax"" type=""positiveInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If present, indicates that the frequency is a range - so to repeat between [frequency] and [frequencyMax] times within the period or period range.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""period"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates the duration of time over which repetitions are to occur; e.g. to express ""3 times per day"", 3 would be the frequency and ""1 day"" would be the period. If periodMax is present, this element indicates the lower bound of the allowed range of the period length.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""periodMax"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If present, indicates that the period is a range from [period] to [periodMax], allowing expressing concepts such as ""do this once every 3-5 days.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""periodUnit"" type=""UnitsOfTime"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The units of time for the period in UCUM units.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""dayOfWeek"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If one or more days of week is provided, then the action happens only on the specified day(s).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""timeOfDay"" type=""time"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Specified time of day for action to take place.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""when"" type=""EventTiming"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">An approximate time period during the day, potentially linked to an event of daily living that indicates when the action should occur.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""offset"" type=""unsignedInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The number of minutes from the event. If the event code does not indicate whether the minutes is before or after the event, then the offset is assumed to be after the event.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""UnitsOfTime-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""s"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">秒</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""min"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">分钟</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""h"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">小时</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""d"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">天</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""wk"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">星期</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""mo"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">月</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""a"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">年</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""UnitsOfTime"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A unit of time (units from UCUM).</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""UnitsOfTime-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""EventTiming-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""MORN"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Morning</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MORN.early"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Early Morning</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MORN.late"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Late Morning</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""NOON"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Noon</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""AFT"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Afternoon</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""AFT.early"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Early Afternoon</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""AFT.late"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Late Afternoon</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""EVE"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Evening</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""EVE.early"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Early Evening</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""EVE.late"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Late Evening</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""NIGHT"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Night</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PHS"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">After Sleep</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HS"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">HS</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""WAKE"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">WAKE</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""C"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">C</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CM"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">CM</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CD"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">CD</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CV"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">CV</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""AC"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">AC</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ACM"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">ACM</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ACD"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">ACD</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ACV"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">ACV</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PC"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">PC</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PCM"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">PCM</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PCD"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">PCD</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PCV"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">PCV</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""EventTiming"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Real world event relating to the schedule.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""EventTiming-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ProdCharacteristic"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""height"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the height can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""width"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the width can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""depth"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the depth can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""weight"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the weight can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""nominalVolume"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the nominal volume can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""externalDiameter"" type=""Quantity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the external diameter can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""shape"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the shape can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""color"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the color can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""imprint"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the imprint can be specified as text.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""image"" type=""Attachment"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the image can be provided The format of the image attachment shall be specified by regional implementations.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""scoring"" type=""CodeableConcept"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Where applicable, the scoring can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""CodeableConcept"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A concept that may be defined by a formal reference to a terminology or ontology or may be provided by text.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""coding"" type=""Coding"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A reference to a code defined by a terminology system.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""text"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A human language representation of the concept as seen/selected/uttered by the user who entered the data and/or which represents the intended meaning of the user.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ParameterDefinition"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">The parameters to the module. This collection specifies both the input and output parameters. Input parameters are provided by the caller as part of the $evaluate operation. Output parameters are included in the GuidanceResponse.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The name of the parameter used to allow access to the value of the parameter in evaluation contexts.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""use"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Whether the parameter is input or output for the module.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""min"" type=""integer"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The minimum number of times this parameter SHALL appear in the request or response.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""max"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The maximum number of times this element is permitted to appear in the request or response.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""documentation"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A brief discussion of what the parameter is for and how it is used by the module.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""type"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The type of the parameter.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""profile"" type=""canonical"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If specified, this indicates a profile that the input data must conform to, or that the output data will conform to.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ElementDefinition"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Captures constraints on each element within the resource, profile, or extension.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""path"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The path identifies the element and is expressed as a "".""-separated list of ancestor elements, beginning with the name of the resource or extension.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""representation"" type=""PropertyRepresentation"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Codes that define how this element is represented in instances, when the deviation varies from the normal case.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""sliceName"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The name of this element definition slice, when slicing is working. The name must be a token with no dots or spaces. This is a unique name referring to a specific set of constraints applied to this element, used to provide a name to different slices of the same element.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""sliceIsConstraining"" type=""boolean"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If true, indicates that this slice definition is constraining a slice definition with the same name in an inherited profile. If false, the slice is not overriding any slice in an inherited profile. If missing, the slice might or might not be overriding a slice in an inherited profile, depending on the sliceName.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""label"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A single preferred label which is the text to display beside the element indicating its meaning or to use to prompt for the element in a user display or form.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""code"" type=""Coding"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A code that has the same meaning as the element in a particular terminology.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""slicing"" type=""ElementDefinition.Slicing"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates that the element is sliced into a set of alternative definitions (i.e. in a structure definition, there are multiple different constraints on a single element in the base resource). Slicing can be used in any resource that has cardinality ..* on the base resource, or any resource with a choice of types. The set of slices is any elements that come after this in the element sequence that have the same path, until a shorter path occurs (the shorter path terminates the set).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""short"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A concise description of what this element means (e.g. for use in autogenerated summaries).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""definition"" type=""markdown"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Provides a complete explanation of the meaning of the data element for human readability.  For the case of elements derived from existing elements (e.g. constraints), the definition SHALL be consistent with the base definition, but convey the meaning of the element in the particular context of use of the resource. (Note: The text you are reading is specified in ElementDefinition.definition).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""comment"" type=""markdown"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Explanatory notes and implementation guidance about the data element, including notes about how to use the data properly, exceptions to proper use, etc. (Note: The text you are reading is specified in ElementDefinition.comment).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""requirements"" type=""markdown"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">This element is for traceability of why the element was created and why the constraints exist as they do. This may be used to point to source materials or specifications that drove the structure of this element.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""alias"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies additional names by which this element might also be known.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""min"" type=""unsignedInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The minimum number of times this element SHALL appear in the instance.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""max"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The maximum number of times this element is permitted to appear in the instance.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""base"" type=""ElementDefinition.Base"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Information about the base definition of the element, provided to make it unnecessary for tools to trace the deviation of the element through the derived and related profiles. When the element definition is not the original definition of an element - i.g. either in a constraint on another type, or for elements from a super type in a snap shot - then the information in provided in the element definition may be different to the base definition. On the original definition of the element, it will be same.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""contentReference"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies an element defined elsewhere in the definition whose content rules should be applied to the current element. ContentReferences bring across all the rules that are in the ElementDefinition for the element, including definitions, cardinality constraints, bindings, invariants etc.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""type"" type=""ElementDefinition.Type"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The data type or resource that the value of this element is permitted to be.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The value that should be used if there is no value stated in the instance (e.g. 'if not otherwise specified, the abstract is false').</xs:documentation>
            </xs:annotation>
            <xs:element name=""defaultValueBase64Binary"" type=""base64Binary"" />
            <xs:element name=""defaultValueBoolean"" type=""boolean"" />
            <xs:element name=""defaultValueCanonical"" type=""canonical"" />
            <xs:element name=""defaultValueCode"" type=""code"" />
            <xs:element name=""defaultValueDate"" type=""date"" />
            <xs:element name=""defaultValueDateTime"" type=""dateTime"" />
            <xs:element name=""defaultValueDecimal"" type=""decimal"" />
            <xs:element name=""defaultValueId"" type=""id"" />
            <xs:element name=""defaultValueInstant"" type=""instant"" />
            <xs:element name=""defaultValueInteger"" type=""integer"" />
            <xs:element name=""defaultValueMarkdown"" type=""markdown"" />
            <xs:element name=""defaultValueOid"" type=""oid"" />
            <xs:element name=""defaultValuePositiveInt"" type=""positiveInt"" />
            <xs:element name=""defaultValueString"" type=""string"" />
            <xs:element name=""defaultValueTime"" type=""time"" />
            <xs:element name=""defaultValueUnsignedInt"" type=""unsignedInt"" />
            <xs:element name=""defaultValueUri"" type=""uri"" />
            <xs:element name=""defaultValueUrl"" type=""url"" />
            <xs:element name=""defaultValueUuid"" type=""uuid"" />
            <xs:element name=""defaultValueAddress"" type=""Address"" />
            <xs:element name=""defaultValueAge"" type=""Age"" />
            <xs:element name=""defaultValueAnnotation"" type=""Annotation"" />
            <xs:element name=""defaultValueAttachment"" type=""Attachment"" />
            <xs:element name=""defaultValueCodeableConcept"" type=""CodeableConcept"" />
            <xs:element name=""defaultValueCoding"" type=""Coding"" />
            <xs:element name=""defaultValueContactPoint"" type=""ContactPoint"" />
            <xs:element name=""defaultValueCount"" type=""Count"" />
            <xs:element name=""defaultValueDistance"" type=""Distance"" />
            <xs:element name=""defaultValueDuration"" type=""Duration"" />
            <xs:element name=""defaultValueHumanName"" type=""HumanName"" />
            <xs:element name=""defaultValueIdentifier"" type=""Identifier"" />
            <xs:element name=""defaultValueMoney"" type=""Money"" />
            <xs:element name=""defaultValuePeriod"" type=""Period"" />
            <xs:element name=""defaultValueQuantity"" type=""Quantity"" />
            <xs:element name=""defaultValueRange"" type=""Range"" />
            <xs:element name=""defaultValueRatio"" type=""Ratio"" />
            <xs:element name=""defaultValueReference"" type=""Reference"" />
            <xs:element name=""defaultValueSampledData"" type=""SampledData"" />
            <xs:element name=""defaultValueSignature"" type=""Signature"" />
            <xs:element name=""defaultValueTiming"" type=""Timing"" />
            <xs:element name=""defaultValueContactDetail"" type=""ContactDetail"" />
            <xs:element name=""defaultValueContributor"" type=""Contributor"" />
            <xs:element name=""defaultValueDataRequirement"" type=""DataRequirement"" />
            <xs:element name=""defaultValueExpression"" type=""Expression"" />
            <xs:element name=""defaultValueParameterDefinition"" type=""ParameterDefinition"" />
            <xs:element name=""defaultValueRelatedArtifact"" type=""RelatedArtifact"" />
            <xs:element name=""defaultValueTriggerDefinition"" type=""TriggerDefinition"" />
            <xs:element name=""defaultValueUsageContext"" type=""UsageContext"" />
            <xs:element name=""defaultValueDosage"" type=""Dosage"" />
            <xs:element name=""defaultValueMeta"" type=""Meta"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""meaningWhenMissing"" type=""markdown"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The Implicit meaning that is to be understood when this element is missing (e.g. 'when this element is missing, the period is ongoing').</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""orderMeaning"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If present, indicates that the order of the repeating element has meaning and describes what that meaning is.  If absent, it means that the order of the element has no meaning.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Specifies a value that SHALL be exactly the value  for this element in the instance. For purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match (case and accent sensitive). Missing elements/attributes must also be missing.</xs:documentation>
            </xs:annotation>
            <xs:element name=""fixedBase64Binary"" type=""base64Binary"" />
            <xs:element name=""fixedBoolean"" type=""boolean"" />
            <xs:element name=""fixedCanonical"" type=""canonical"" />
            <xs:element name=""fixedCode"" type=""code"" />
            <xs:element name=""fixedDate"" type=""date"" />
            <xs:element name=""fixedDateTime"" type=""dateTime"" />
            <xs:element name=""fixedDecimal"" type=""decimal"" />
            <xs:element name=""fixedId"" type=""id"" />
            <xs:element name=""fixedInstant"" type=""instant"" />
            <xs:element name=""fixedInteger"" type=""integer"" />
            <xs:element name=""fixedMarkdown"" type=""markdown"" />
            <xs:element name=""fixedOid"" type=""oid"" />
            <xs:element name=""fixedPositiveInt"" type=""positiveInt"" />
            <xs:element name=""fixedString"" type=""string"" />
            <xs:element name=""fixedTime"" type=""time"" />
            <xs:element name=""fixedUnsignedInt"" type=""unsignedInt"" />
            <xs:element name=""fixedUri"" type=""uri"" />
            <xs:element name=""fixedUrl"" type=""url"" />
            <xs:element name=""fixedUuid"" type=""uuid"" />
            <xs:element name=""fixedAddress"" type=""Address"" />
            <xs:element name=""fixedAge"" type=""Age"" />
            <xs:element name=""fixedAnnotation"" type=""Annotation"" />
            <xs:element name=""fixedAttachment"" type=""Attachment"" />
            <xs:element name=""fixedCodeableConcept"" type=""CodeableConcept"" />
            <xs:element name=""fixedCoding"" type=""Coding"" />
            <xs:element name=""fixedContactPoint"" type=""ContactPoint"" />
            <xs:element name=""fixedCount"" type=""Count"" />
            <xs:element name=""fixedDistance"" type=""Distance"" />
            <xs:element name=""fixedDuration"" type=""Duration"" />
            <xs:element name=""fixedHumanName"" type=""HumanName"" />
            <xs:element name=""fixedIdentifier"" type=""Identifier"" />
            <xs:element name=""fixedMoney"" type=""Money"" />
            <xs:element name=""fixedPeriod"" type=""Period"" />
            <xs:element name=""fixedQuantity"" type=""Quantity"" />
            <xs:element name=""fixedRange"" type=""Range"" />
            <xs:element name=""fixedRatio"" type=""Ratio"" />
            <xs:element name=""fixedReference"" type=""Reference"" />
            <xs:element name=""fixedSampledData"" type=""SampledData"" />
            <xs:element name=""fixedSignature"" type=""Signature"" />
            <xs:element name=""fixedTiming"" type=""Timing"" />
            <xs:element name=""fixedContactDetail"" type=""ContactDetail"" />
            <xs:element name=""fixedContributor"" type=""Contributor"" />
            <xs:element name=""fixedDataRequirement"" type=""DataRequirement"" />
            <xs:element name=""fixedExpression"" type=""Expression"" />
            <xs:element name=""fixedParameterDefinition"" type=""ParameterDefinition"" />
            <xs:element name=""fixedRelatedArtifact"" type=""RelatedArtifact"" />
            <xs:element name=""fixedTriggerDefinition"" type=""TriggerDefinition"" />
            <xs:element name=""fixedUsageContext"" type=""UsageContext"" />
            <xs:element name=""fixedDosage"" type=""Dosage"" />
            <xs:element name=""fixedMeta"" type=""Meta"" />
          </xs:choice>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Specifies a value that the value in the instance SHALL follow - that is, any value in the pattern must be found in the instance. Other additional values may be found too. This is effectively constraint by example.
								When pattern[x] is used to constrain a primitive, it means that the value provided in the pattern[x] must match the instance value exactly.
								When pattern[x] is used to constrain an array, it means that each element provided in the pattern[x] array must (recursively) match at least one element from the instance array.
								When pattern[x] is used to constrain a complex object, it means that each property in the pattern must be present in the complex object, and its value must recursively match -- i.e.,
								1. If primitive: it must match exactly the pattern value
								2. If a complex object: it must match (recursively) the pattern value
								3. If an array: it must match (recursively) the pattern value.</xs:documentation>
            </xs:annotation>
            <xs:element name=""patternBase64Binary"" type=""base64Binary"" />
            <xs:element name=""patternBoolean"" type=""boolean"" />
            <xs:element name=""patternCanonical"" type=""canonical"" />
            <xs:element name=""patternCode"" type=""code"" />
            <xs:element name=""patternDate"" type=""date"" />
            <xs:element name=""patternDateTime"" type=""dateTime"" />
            <xs:element name=""patternDecimal"" type=""decimal"" />
            <xs:element name=""patternId"" type=""id"" />
            <xs:element name=""patternInstant"" type=""instant"" />
            <xs:element name=""patternInteger"" type=""integer"" />
            <xs:element name=""patternMarkdown"" type=""markdown"" />
            <xs:element name=""patternOid"" type=""oid"" />
            <xs:element name=""patternPositiveInt"" type=""positiveInt"" />
            <xs:element name=""patternString"" type=""string"" />
            <xs:element name=""patternTime"" type=""time"" />
            <xs:element name=""patternUnsignedInt"" type=""unsignedInt"" />
            <xs:element name=""patternUri"" type=""uri"" />
            <xs:element name=""patternUrl"" type=""url"" />
            <xs:element name=""patternUuid"" type=""uuid"" />
            <xs:element name=""patternAddress"" type=""Address"" />
            <xs:element name=""patternAge"" type=""Age"" />
            <xs:element name=""patternAnnotation"" type=""Annotation"" />
            <xs:element name=""patternAttachment"" type=""Attachment"" />
            <xs:element name=""patternCodeableConcept"" type=""CodeableConcept"" />
            <xs:element name=""patternCoding"" type=""Coding"" />
            <xs:element name=""patternContactPoint"" type=""ContactPoint"" />
            <xs:element name=""patternCount"" type=""Count"" />
            <xs:element name=""patternDistance"" type=""Distance"" />
            <xs:element name=""patternDuration"" type=""Duration"" />
            <xs:element name=""patternHumanName"" type=""HumanName"" />
            <xs:element name=""patternIdentifier"" type=""Identifier"" />
            <xs:element name=""patternMoney"" type=""Money"" />
            <xs:element name=""patternPeriod"" type=""Period"" />
            <xs:element name=""patternQuantity"" type=""Quantity"" />
            <xs:element name=""patternRange"" type=""Range"" />
            <xs:element name=""patternRatio"" type=""Ratio"" />
            <xs:element name=""patternReference"" type=""Reference"" />
            <xs:element name=""patternSampledData"" type=""SampledData"" />
            <xs:element name=""patternSignature"" type=""Signature"" />
            <xs:element name=""patternTiming"" type=""Timing"" />
            <xs:element name=""patternContactDetail"" type=""ContactDetail"" />
            <xs:element name=""patternContributor"" type=""Contributor"" />
            <xs:element name=""patternDataRequirement"" type=""DataRequirement"" />
            <xs:element name=""patternExpression"" type=""Expression"" />
            <xs:element name=""patternParameterDefinition"" type=""ParameterDefinition"" />
            <xs:element name=""patternRelatedArtifact"" type=""RelatedArtifact"" />
            <xs:element name=""patternTriggerDefinition"" type=""TriggerDefinition"" />
            <xs:element name=""patternUsageContext"" type=""UsageContext"" />
            <xs:element name=""patternDosage"" type=""Dosage"" />
            <xs:element name=""patternMeta"" type=""Meta"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""example"" type=""ElementDefinition.Example"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A sample value for this element demonstrating the type of information that would typically be found in the element.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The minimum allowed value for the element. The value is inclusive. This is allowed for the types date, dateTime, instant, time, decimal, integer, and Quantity.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""minValueDate"" type=""date"" />
            <xs:element maxOccurs=""1"" name=""minValueDateTime"" type=""dateTime"" />
            <xs:element maxOccurs=""1"" name=""minValueInstant"" type=""instant"" />
            <xs:element maxOccurs=""1"" name=""minValueTime"" type=""time"" />
            <xs:element maxOccurs=""1"" name=""minValueDecimal"" type=""decimal"" />
            <xs:element maxOccurs=""1"" name=""minValueInteger"" type=""integer"" />
            <xs:element maxOccurs=""1"" name=""minValuePositiveInt"" type=""positiveInt"" />
            <xs:element maxOccurs=""1"" name=""minValueUnsignedInt"" type=""unsignedInt"" />
            <xs:element maxOccurs=""1"" name=""minValueQuantity"" type=""Quantity"" />
          </xs:choice>
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The maximum allowed value for the element. The value is inclusive. This is allowed for the types date, dateTime, instant, time, decimal, integer, and Quantity.</xs:documentation>
            </xs:annotation>
            <xs:element maxOccurs=""1"" name=""maxValueDate"" type=""date"" />
            <xs:element maxOccurs=""1"" name=""maxValueDateTime"" type=""dateTime"" />
            <xs:element maxOccurs=""1"" name=""maxValueInstant"" type=""instant"" />
            <xs:element maxOccurs=""1"" name=""maxValueTime"" type=""time"" />
            <xs:element maxOccurs=""1"" name=""maxValueDecimal"" type=""decimal"" />
            <xs:element maxOccurs=""1"" name=""maxValueInteger"" type=""integer"" />
            <xs:element maxOccurs=""1"" name=""maxValuePositiveInt"" type=""positiveInt"" />
            <xs:element maxOccurs=""1"" name=""maxValueUnsignedInt"" type=""unsignedInt"" />
            <xs:element maxOccurs=""1"" name=""maxValueQuantity"" type=""Quantity"" />
          </xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxLength"" type=""integer"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates the maximum length in characters that is permitted to be present in conformant instances and which is expected to be supported by conformant consumers that support the element.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""condition"" type=""id"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A reference to an invariant that may make additional statements about the cardinality or value in the instance.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""constraint"" type=""ElementDefinition.Constraint"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Formal constraints such as co-occurrence and other constraints that can be computationally evaluated within the context of the instance.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""mustSupport"" type=""boolean"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If true, implementations that produce or consume resources SHALL provide ""support"" for the element in some meaningful way.  If false, the element may be ignored and not supported. If false, whether to populate or use the data element in any way is at the discretion of the implementation.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""isModifier"" type=""boolean"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If true, the value of this element affects the interpretation of the element or resource that contains it, and the value of the element cannot be ignored. Typically, this is used for status, negation and qualification codes. The effect of this is that the element cannot be ignored by systems: they SHALL either recognize the element and process it, and/or a pre-determination has been made that it is not relevant to their particular system.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""isModifierReason"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Explains how that element affects the interpretation of the resource or element that contains it.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""isSummary"" type=""boolean"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Whether the element should be included if a client requests a search with the parameter _summary=true.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""binding"" type=""ElementDefinition.Binding"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Binds to a value set if this element is coded (code, Coding, CodeableConcept, Quantity), or the data types (string, uri).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""mapping"" type=""ElementDefinition.Mapping"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies a concept from an external specification that roughly corresponds to this element.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ElementDefinition.Constraint"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Captures constraints on each element within the resource, profile, or extension.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""key"" type=""id"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Allows identification of which elements have their cardinalities impacted by the constraint.  Will not be referenced for constraints that do not affect cardinality.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""requirements"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Description of why this constraint is necessary or appropriate.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""severity"" type=""ConstraintSeverity"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies the impact constraint violation has on the conformance of the instance.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""human"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Text that can be used to describe the constraint in messages identifying that the constraint has been violated.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""expression"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A [FHIRPath](fhirpath.html) expression of constraint that can be executed to see if this constraint is met.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""xpath"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">An XPath expression of constraint that can be executed to see if this constraint is met.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""source"" type=""canonical"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A reference to the original source of the constraint, for traceability purposes.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ElementDefinition.Mapping"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Captures constraints on each element within the resource, profile, or extension.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""identity"" type=""id"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">An internal reference to the definition of a mapping.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""language"" type=""code"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies the computable language in which mapping.map is expressed.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""map"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Expresses what part of the target specification corresponds to this element.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""comment"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Comments that provide information about the mapping or its use.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ElementDefinition.Base"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Captures constraints on each element within the resource, profile, or extension.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""path"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The Path that identifies the base element - this matches the ElementDefinition.path for that element. Across FHIR, there is only one base definition of any element - that is, an element definition on a [[[StructureDefinition]]] without a StructureDefinition.base.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""min"" type=""unsignedInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Minimum cardinality of the base element identified by the path.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""max"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Maximum cardinality of the base element identified by the path.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ElementDefinition.Type"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Captures constraints on each element within the resource, profile, or extension.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""code"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">URL of Data type or Resource that is a(or the) type used for this element. References are URLs that are relative to http://hl7.org/fhir/StructureDefinition e.g. ""string"" is a reference to http://hl7.org/fhir/StructureDefinition/string. Absolute URLs are only allowed in logical models.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""profile"" type=""canonical"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Identifies a profile structure or implementation Guide that applies to the datatype this element refers to. If any profiles are specified, then the content must conform to at least one of them. The URL can be a local reference - to a contained StructureDefinition, or a reference to another StructureDefinition or Implementation Guide by a canonical URL. When an implementation guide is specified, the type SHALL conform to at least one profile defined in the implementation guide.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""targetProfile"" type=""canonical"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Used when the type is ""Reference"" or ""canonical"", and identifies a profile structure or implementation Guide that applies to the target of the reference this element refers to. If any profiles are specified, then the content must conform to at least one of them. The URL can be a local reference - to a contained StructureDefinition, or a reference to another StructureDefinition or Implementation Guide by a canonical URL. When an implementation guide is specified, the target resource SHALL conform to at least one profile defined in the implementation guide.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""aggregation"" type=""AggregationMode"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If the type is a reference to another resource, how the resource is or can be aggregated - is it a contained resource, or a reference, and if the context is a bundle, is it included in the bundle.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""versioning"" type=""ReferenceVersionRules"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Whether this reference needs to be version specific or version independent, or whether either can be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ElementDefinition.Example"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Captures constraints on each element within the resource, profile, or extension.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""label"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Describes the purpose of this example amoung the set of examples.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:choice minOccurs=""1"" maxOccurs=""1"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The actual value for the element, which must be one of the types allowed for this element.</xs:documentation>
            </xs:annotation>
            <xs:element name=""valueBase64Binary"" type=""base64Binary"" />
            <xs:element name=""valueBoolean"" type=""boolean"" />
            <xs:element name=""valueCanonical"" type=""canonical"" />
            <xs:element name=""valueCode"" type=""code"" />
            <xs:element name=""valueDate"" type=""date"" />
            <xs:element name=""valueDateTime"" type=""dateTime"" />
            <xs:element name=""valueDecimal"" type=""decimal"" />
            <xs:element name=""valueId"" type=""id"" />
            <xs:element name=""valueInstant"" type=""instant"" />
            <xs:element name=""valueInteger"" type=""integer"" />
            <xs:element name=""valueMarkdown"" type=""markdown"" />
            <xs:element name=""valueOid"" type=""oid"" />
            <xs:element name=""valuePositiveInt"" type=""positiveInt"" />
            <xs:element name=""valueString"" type=""string"" />
            <xs:element name=""valueTime"" type=""time"" />
            <xs:element name=""valueUnsignedInt"" type=""unsignedInt"" />
            <xs:element name=""valueUri"" type=""uri"" />
            <xs:element name=""valueUrl"" type=""url"" />
            <xs:element name=""valueUuid"" type=""uuid"" />
            <xs:element name=""valueAddress"" type=""Address"" />
            <xs:element name=""valueAge"" type=""Age"" />
            <xs:element name=""valueAnnotation"" type=""Annotation"" />
            <xs:element name=""valueAttachment"" type=""Attachment"" />
            <xs:element name=""valueCodeableConcept"" type=""CodeableConcept"" />
            <xs:element name=""valueCoding"" type=""Coding"" />
            <xs:element name=""valueContactPoint"" type=""ContactPoint"" />
            <xs:element name=""valueCount"" type=""Count"" />
            <xs:element name=""valueDistance"" type=""Distance"" />
            <xs:element name=""valueDuration"" type=""Duration"" />
            <xs:element name=""valueHumanName"" type=""HumanName"" />
            <xs:element name=""valueIdentifier"" type=""Identifier"" />
            <xs:element name=""valueMoney"" type=""Money"" />
            <xs:element name=""valuePeriod"" type=""Period"" />
            <xs:element name=""valueQuantity"" type=""Quantity"" />
            <xs:element name=""valueRange"" type=""Range"" />
            <xs:element name=""valueRatio"" type=""Ratio"" />
            <xs:element name=""valueReference"" type=""Reference"" />
            <xs:element name=""valueSampledData"" type=""SampledData"" />
            <xs:element name=""valueSignature"" type=""Signature"" />
            <xs:element name=""valueTiming"" type=""Timing"" />
            <xs:element name=""valueContactDetail"" type=""ContactDetail"" />
            <xs:element name=""valueContributor"" type=""Contributor"" />
            <xs:element name=""valueDataRequirement"" type=""DataRequirement"" />
            <xs:element name=""valueExpression"" type=""Expression"" />
            <xs:element name=""valueParameterDefinition"" type=""ParameterDefinition"" />
            <xs:element name=""valueRelatedArtifact"" type=""RelatedArtifact"" />
            <xs:element name=""valueTriggerDefinition"" type=""TriggerDefinition"" />
            <xs:element name=""valueUsageContext"" type=""UsageContext"" />
            <xs:element name=""valueDosage"" type=""Dosage"" />
            <xs:element name=""valueMeta"" type=""Meta"" />
          </xs:choice>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ElementDefinition.Slicing"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Captures constraints on each element within the resource, profile, or extension.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""discriminator"" type=""ElementDefinition.Discriminator"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Designates which child elements are used to discriminate between the slices when processing an instance. If one or more discriminators are provided, the value of the child elements in the instance data SHALL completely distinguish which slice the element in the resource matches based on the allowed values for those elements in each of the slices.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""description"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A human-readable text description of how the slicing works. If there is no discriminator, this is required to be present to provide whatever information is possible about how the slices can be differentiated.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ordered"" type=""boolean"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If the matching elements have to occur in the same order as defined in the profile.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""rules"" type=""SlicingRules"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Whether additional slices are allowed or not. When the slices are ordered, profile authors can also say that additional slices are only allowed at the end.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ElementDefinition.Binding"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Captures constraints on each element within the resource, profile, or extension.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""strength"" type=""BindingStrength"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates the degree of conformance expectations associated with this binding - that is, the degree to which the provided value set must be adhered to in the instances.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""description"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Describes the intended use of this particular set of codes.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""valueSet"" type=""canonical"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Refers to the value set that identifies the set of codes the binding refers to.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ElementDefinition.Discriminator"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Captures constraints on each element within the resource, profile, or extension.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have a value for at least one of the defined elements, an @id referenced from the Narrative, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""type"" type=""DiscriminatorType"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">How the element value is interpreted when discrimination is evaluated.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""path"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A FHIRPath expression, using [the simple subset of FHIRPath](fhirpath.html#simple), that is used to identify the element on which discrimination is based.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""PropertyRepresentation-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""xmlAttr"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">XML Attribute</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""xmlText"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">XML Text</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""typeAttr"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Type Attribute</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""cdaText"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">CDA Text Format</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""xhtml"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">XHTML</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""PropertyRepresentation"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">How a property is represented when serialized.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""PropertyRepresentation-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""ConstraintSeverity-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""error"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Error</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""warning"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Warning</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ConstraintSeverity"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">SHALL applications comply with this constraint?</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""ConstraintSeverity-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""AggregationMode-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""contained"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Contained</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""referenced"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Referenced</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""bundled"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Bundled</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""AggregationMode"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">How resource references can be aggregated.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""AggregationMode-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""ReferenceVersionRules-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""either"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Either Specific or independent</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""independent"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Version independent</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""specific"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Version Specific</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ReferenceVersionRules"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Whether a reference needs to be version specific or version independent, or whether either can be used.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""ReferenceVersionRules-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""SlicingRules-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""closed"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Closed</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""open"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Open</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""openAtEnd"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Open at End</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""SlicingRules"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">How slices are interpreted when evaluating an instance.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""SlicingRules-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""BindingStrength-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""required"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Required</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""extensible"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Extensible</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""preferred"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Preferred</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""example"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Example</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""BindingStrength"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Indication of the degree of conformance expectations associated with a binding.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""BindingStrength-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""DiscriminatorType-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""value"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Value</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""exists"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Exists</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""pattern"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Pattern</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""type"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Type</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""profile"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Profile</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""DiscriminatorType"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">How an element value is interpreted when discrimination is evaluated.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""DiscriminatorType-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""DomainResource"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A resource that includes narrative, extensions, and contained resources.</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Resource"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""text"" type=""Narrative"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it ""clinically safe"" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""contained"" type=""ResourceContainer"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""extension"" type=""Extension"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""modifierExtension"" type=""Extension"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
								Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Resource"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">This is the base resource type for everything.</xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""id"" type=""id"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""meta"" type=""Meta"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""implicitRules"" type=""uri"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""language"" type=""code"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">The base language in which the resource is written.</xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:simpleType name=""PublicationStatus-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""draft"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Draft</xs:documentation>
          <xs:documentation xml:lang=""ru"">черновик</xs:documentation>
          <xs:documentation xml:lang=""nl"">ontwerp</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""active"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Active</xs:documentation>
          <xs:documentation xml:lang=""ru"">активный</xs:documentation>
          <xs:documentation xml:lang=""nl"">actief</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""retired"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Retired</xs:documentation>
          <xs:documentation xml:lang=""ru"">удалён</xs:documentation>
          <xs:documentation xml:lang=""nl"">verouderd</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""unknown"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Unknown</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""PublicationStatus"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"" />
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""PublicationStatus-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""SearchParamType-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""number"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Number</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""date"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Date/DateTime</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""string"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">String</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""token"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Token</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""reference"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Reference</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""composite"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Composite</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""quantity"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Quantity</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""uri"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">URI</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""special"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Special</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""SearchParamType"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"" />
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""SearchParamType-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""AdministrativeGender-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""male"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Male</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""female"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Female</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""other"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Other</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""unknown"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Unknown</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""AdministrativeGender"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"" />
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""AdministrativeGender-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""FHIRVersion-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""0.01"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">0.01</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""0.05"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">0.05</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""0.06"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">0.06</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""0.11"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">0.11</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""0.0.80"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">0.0.80</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""0.0.81"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">0.0.81</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""0.0.82"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">0.0.82</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""0.4.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">0.4.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""0.5.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">0.5.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1.0.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">1.0.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1.0.1"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">1.0.1</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1.0.2"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">1.0.2</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1.1.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">1.1.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1.4.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">1.4.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1.6.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">1.6.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1.8.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">1.8.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""3.0.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">3.0.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""3.0.1"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">3.0.1</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""3.3.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">3.3.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""3.5.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">3.5.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""4.0.0"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">4.0.0</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""4.0.1"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">4.0.1</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""FHIRVersion"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"" />
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""FHIRVersion-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NoteType-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""display"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Display</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""print"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Print (Form)</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""printoper"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Print (Operator)</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""NoteType"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"" />
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""NoteType-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""RemittanceOutcome-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""queued"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Queued</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""complete"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Processing Complete</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""error"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Error</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""partial"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Partial Processing</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""RemittanceOutcome"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"" />
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""RemittanceOutcome-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""ConceptMapEquivalence-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""relatedto"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Related To</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""equivalent"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Equivalent</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""equal"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Equal</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""wider"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Wider</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""subsumes"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Subsumes</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""narrower"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Narrower</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""specializes"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Specializes</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""inexact"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Inexact</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""unmatched"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Unmatched</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""disjoint"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Disjoint</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ConceptMapEquivalence"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"" />
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""ConceptMapEquivalence-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""DocumentReferenceStatus-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""current"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Current</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""superseded"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Superseded</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""entered-in-error"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Entered in Error</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""DocumentReferenceStatus"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"" />
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""DocumentReferenceStatus-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
</xs:schema>";
        
        public fhir_base() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [0];
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
