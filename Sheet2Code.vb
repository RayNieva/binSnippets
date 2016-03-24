Public CompanyName As String
Public companyString As String
Public CompanyTelephone As String
Public Street As String
Public Town As String




'Manipulated Data from Sheet1 needs to get here to Sheet2
Sub sbGetHomeAddress()

MsgBox Sheet1.Cells(5, 3)
'Here the first value is Row Value and the second one is column value
'Cells(1, 1) means first row first column
End Sub

'Or should Data get manipulated here instead.

'If Data should be manipulated here. (See Next)

'   Read Required Cells in Order

'   Storage of Cells in Specific Order

'   Verify Cells have been read in Specific Order
Sub sbGetEmployeeName()
    Dim EmployeeName As String
    Dim length As Integer
    Dim gap As Integer
    Dim firstname As String
    Dim lastname As String
    Dim emailString As String
    

    MsgBox Sheet2.Cells(3, 3)
'Here the first value is Row Value and the second one is column value
'Cells(1, 1) means first row first column
    EmployeeName = Sheet2.Cells(3, 3)
    'MsgBox "Test Variable EmployeeName " & EmployeeName
    
    length = Len(EmployeeName)
    'MsgBox length
    
    gap = InStr(EmployeeName, " ")
    'MsgBox gap
    
    firstname = Left(EmployeeName, gap - 1)
    'MsgBox firstname
    
    lastname = Right(EmployeeName, length - gap)
    'MsgBox lastname
    
    'MsgBox LCase(firstname)
    'MsgBox LCase(lastname)
    sbGetCompany
    emailString = LCase(firstname) & "." & LCase(lastname) & "@" & companyString
    MsgBox emailString
    
    'Need to assign value to cell
    'Cells(i, j + 1).Value = "Exploitation"
    Sheet2.Cells(13, 3).Value = emailString
    Debug.Print ""
    Debug.Print emailString
    Debug.Print firstname & "\" & " " & lastname
    
    
    
End Sub

Sub sbGetCompany()
' Does not like this here => Public CompanyName As String
'Dim companyString As String
Dim firstString As String
Dim lastString As String
Dim lowcaseString As String
Dim length As Integer
Dim gap As Integer
Dim domain As String

'MsgBox "Company: " & Sheet2.Cells(4, 3)
'Here the first value is Row Value and the second one is column value
'Cells(1, 1) means first row first column
CompanyName = Sheet2.Cells(4, 3)
'CompanyName = "Consolidated Concepts"
'CompanyName = "FoodBam"
'CompanyName = "IPS"
'MsgBox "Test Variable CompanyName " & CompanyName
'MsgBox LCase(CompanyName)
length = Len(CompanyName)
'MsgBox length

gap = InStr(CompanyName, " ")
'MsgBox gap
'If gap is 0 then it is a one word company.
If gap = 0 Then
        lowString = LCase(CompanyName)
        'MsgBox lowString
        If lowString = "ips" Then
            lowString = "ipsrebates"
        End If
        
        companyString = lowString & ".com"
        MsgBox companyString
    Exit Sub
End If

'MsgBox Left(CompanyName, gap - 1)
'MsgBox Right(CompanyName, length - gap)
firstString = LCase(Left(CompanyName, gap - 1))
lastString = LCase(Right(CompanyName, length - gap))
If firstString = "consolidated" Then
        domain = ".net"
    Else:
        domain = ".com"
End If

companyString = firstString & lastString & domain
MsgBox companyString
Debug.Print companyString

End Sub

Sub sbGetTitle()

MsgBox "Title: " & Sheet2.Cells(5, 3)
'Here the first value is Row Value and the second one is column value
'Cells(1, 1) means first row first column
Debug.Print Sheet2.Cells(5, 3)
End Sub

Sub sbGetMgr()

MsgBox "Manager: " & Sheet2.Cells(6, 3)
'Here the first value is Row Value and the second one is column value
'Cells(1, 1) means first row first column
End Sub
Sub sbGetHomeAddress1()
    Dim length As Integer
    Dim gap As Integer
    Dim comma As Integer
    Dim strt(1 To 7) As String
    Dim i As Integer
    Dim start As Integer
    Dim HomeAddress As String
    Dim HomeAddressRemainder As String
    Dim StringArray(1 To 7) As String
    'Dim oldGap As String this actually makes no sense as oldGap has no context with HomeAddressRemainder
    Dim ttlLength As Integer
    Dim zip As String
    Dim stateZip As String
    Dim state As String
    Dim lastComma As Integer
    Dim previousHomeAddressRemainder
    Dim commaFromRight As Integer
    Dim startFromRight As Integer
    
    
    
    start = 1
    startFromRight = 1
    'i = 1
    'MsgBox "Home Address: " & Sheet1.Cells(5, 3)
    HomeAddress = Sheet1.Cells(5, 3)
    MsgBox "Test Variable HomeAddress  " & HomeAddress
    ttlLength = Len(HomeAddress)
    'MsgBox "ttlLength= " & ttlLength
    HomeAddressRemainder = HomeAddress
    zip = Right(HomeAddress, 5)
    stateZip = Right(HomeAddress, 8)
    'MsgBox "Zip= " & zip
    'MsgBox "stateZip= " & stateZip
    state = Left(stateZip, 2)
    'MsgBox "state= " & state
    commaFromRight = InStrRev(HomeAddress, ",")
    'Debug.Print HomeAddress
    'MsgBox "commaFromRight= " & commaFromRight
    
    'strt(1) = "19"
    'strt(2) = "Stuart"
    'strt(3) = "Street"
    'MsgBox strt(i)
    
    'What kind of loop?
    For i = 1 To 7
        start = 1
        gap = InStr(start, HomeAddressRemainder, " ")
        'MsgBox "gap: " & gap
        'MsgBox "oldGap=" & oldGap
        comma = InStr(start, HomeAddressRemainder, ",")
        'MsgBox "comma: " & comma
        'commaFromRight = InStrRev(HomeAddress, " ", startFromRight)
        'MsgBox "commaFromRight= " & commaFromRight
        
        'MsgBox "lastComma= " & lastComma
        
        
        If comma = 0 Then
        'If gap = 0 Then
            'MsgBox "HomeAddressRemainder= " & HomeAddressRemainder & " Alert 2nd Loop"
            'MsgBox "previousHomeAddressRemainder= " & HomeAddressRemainder
            'MsgBox "strt 1=" & strt(1)
            'MsgBox "strt 2=" & strt(2)
            'MsgBox "strt 3=" & strt(3)
            'MsgBox "strt 4=" & strt(4)
            'MsgBox "strt 5=" & strt(5)
            'MsgBox "strt 6=" & strt(6)
            'MsgBox "strt 7=" & strt(7)
            'MsgBox "state= " & state
            Debug.Print state
            MsgBox "zip= " & zip
            Debug.Print zip
            MsgBox "Exiting Sub"
            Exit Sub
        End If
        
        
        
        strt(i) = Left(HomeAddressRemainder, gap - 1) & "\"
        'MsgBox "strt " & i & " " & strt(i)
        StringArray(i) = strt(i)
        'MsgBox "stringArray " & i & " " & stringArray(i)
        previousHomeAddressRemainder = HomeAddressRemainder
        'MsgBox "previousHomeAddressRemainder= " & previousHomeAddressRemainder
        start = gap + 1
        HomeAddressRemainder = Mid(HomeAddressRemainder, start)
        'MsgBox "HomeAddressRemainder= " & HomeAddressRemainder
        lastComma = comma
        
        'oldGap = gap
    Next i
    
    
    MsgBox "Looping Out"
    MsgBox "strt " & i & " " & strt(1)
    MsgBox "strt " & i & " " & strt(2)
    MsgBox "strt " & i & " " & strt(3)
    MsgBox "strt " & i & " " & strt(4)
    MsgBox "strt " & i & " " & strt(5)
    MsgBox "strt " & i & " " & strt(6)
    MsgBox "strt " & i & " " & strt(7)
    
    
    'length = Len(HomeAddress)
    'MsgBox length
End Sub
Sub sbGetPersonalPhone()

MsgBox "Personal Phone: " & Sheet2.Cells(7, 3)
'Here the first value is Row Value and the second one is column value
'Cells(1, 1) means first row first column
Debug.Print Sheet2.Cells(7, 3)
End Sub

Sub sbGetPersonalEmailAddress()

MsgBox "Personal Email Address: " & Sheet2.Cells(8, 3)
'Here the first value is Row Value and the second one is column value
'Cells(1, 1) means first row first column
Debug.Print Sheet2.Cells(8, 3)

End Sub

Sub sbGetCompanyTelephone()
    'Dim CompanyTelephone As String
    

    'Need to find a way of storing list of company numbers and making a choice based on location of person
    'Or based on name of company also
    'CompanyName = "Consolidated Concepts"
    'MsgBox CompanyName
    If CompanyName = "Dining Alliance" Then
        CompanyTelephone = "617-275-8430"
        MsgBox CompanyTelephone
    ElseIf CompanyName = "Consolidated Concepts" Then
        CompanyTelephone = "617-245-2922"
        MsgBox CompanyTelephone
    ElseIf CompanyName = "FoodBAM" Then
        CompanyTelephone = "617-250-1610"
        MsgBox CompanyTelephone
    ElseIf CompanyName = "IPS" Then
        CompanyTelephone = "800-426-9883"
        MsgBox CompanyTelephone
    Else
        CompanyTelephone = "617-275-8430"
        MsgBox CompanyTelephone
    
        
    End If
    Sheet2.Cells(14, 3).Value = CompanyTelephone
'    Debug.Print CompanyTelephone
    
    
        
    
    
    
End Sub
Sub sbGetCompanyPhoneExtension()
    'Need to find a way of storing a list of available extensions
    MsgBox "x" & Sheet2.Cells(15, 3)
 '   Debug.Print "x" & Sheet2.Cells(15, 3)
    Debug.Print CompanyTelephone & "\ " & "x" & Sheet2.Cells(15, 3)
End Sub

'   Manipulate Data in Cells to Output a specific way
'       First Data Set is for this Form

Sub Fillform()
    
    sbGetEmployeeName
    'sbGetCompany
    sbGetCompanyTelephone
    
    
End Sub


'       Second Data Set is for Ruby Loading Script


'Reference EmployeeWorkSheetCodeGenerator for generating phone extension sequence.
'Can this be automated somehow?


'This Data needs to go to the current Clipboard to output for the running the Ruby loading script




'Somehow this program should get stored into the Ditto Clipboard  for later use.
Sub sbGenerateRubyArray()
    sbGetEmployeeName
    'sbGetHomeAddress1
    TestRegex2
    sbGetCompanyTelephone
    sbGetCompanyPhoneExtension
    sbGetPersonalPhone
    sbGetPersonalEmailAddress
    sbGetTitle
    sbGetCompany
    
    
    
End Sub


Private Sub ComboBoxDiningAlliance_Change()



End Sub

Sub TestInstrRevFunction()
Dim ThisString
Dim FindStr As Integer
Dim FindStr2 As Integer

ThisString = "101 Prospect St. North Braintree,MA 02184"


FindStr = InStrRev(ThisString, " ", 39)
FindStr2 = InStr(1, ThisString, " ")
MsgBox "FindStr= " & FindStr
MsgBox "FindStr2= " & FindStr2


End Sub

Sub TestRegex()
'objRegExp_1 as
Dim objRegExp_1 As New regExp
Dim strToSearch As String
Dim strPattern As String: strPattern = "^.*St.|Street|Avenue|Ave.$"
Dim showString As Object


Set objRegExp_1 = CreateObject("vbscript.regexp")
objRegExp_1.Global = True
objRegExp_1.IgnoreCase = True
'objRegExp_1.Pattern=[a-z,A-Z]*@[a-z,A-Z]*.com
objRegExp_1.Pattern = strPattern
strToSearch = "101 Prospect Avenue North Braintree,MA 02184"
'strToSearch = "St."

If objRegExp_1.Test(strToSearch) Then
    MsgBox "Found"
Else
    MsgBox "Not Found"
End If

Set showString = objRegExp_1.Execute(strToSearch)
'showString.

'Set regExp_Matches = objRegExp_1.Execute(strToSearch)

'If regExp_Matches.Count = 1 Then
    'MsgBox ("This string is a Found.")
'End If
'[Street|St.|Avenue|Ave|Court|Ct]
MsgBox "Did It"
Set objRegExp_1 = Nothing

End Sub

Function Area(x As Double, y As Double) As Double

Area = x * y

End Function

Sub calculateArea()
    Dim answer As Double
    Dim x As Double
    Dim y As Double
    
    x = 2#
    y = 3#
    
    answer = Area(x, y)
    Debug.Print answer
    Debug.Assert answer
End Sub

Function StreetTest(ByVal text As String) As String
  Dim result As String
  Dim allMatches As MatchCollection
  Dim ST As regExp
  
  
  

  Set ST = CreateObject("VBScript.RegExp")
  ST.IgnoreCase = True
  ST.Pattern = "^[0-9]*\s[a-z,A-Z]*\s(St.|Street|Avenue|Ave.|Circle|Cir.|Drive|Dr.)"
  'ST.Pattern = "Hello"
  ST.Global = True
  
  Set allMatches = ST.Execute(text)

  If allMatches.Count <> 0 Then
    result = allMatches.Item(0)
    MsgBox result
    Debug.Print result
  End If
  
  StreetTest = result
  
  End Function
Function TownTest(ByVal text As String) As String
  Dim result2 As String
  Dim allMatches2 As MatchCollection
  Dim TN As regExp
  Dim Town1 As String
  Dim LengthOfString As Integer
  
  
  Set TN = CreateObject("VBScript.RegExp")
  TN.IgnoreCase = True
  TN.Pattern = "(North|South|East|West)\s[a-z,A-Z]*,"
  'TN.Pattern = "North"
  TN.Global = True
  
  Set allMatches2 = TN.Execute(text)

  If allMatches2.Count <> 0 Then
    result2 = allMatches2.Item(0)
    
    MsgBox result2
    'Debug.Print result2
    LengthOfString = Len(result2)
    Town1 = Left(result2, LengthOfString - 1)
    Debug.Print Town1
  Else
    MsgBox "No Region Matches"
        TownTest2 (text)
    
    
    
  End If
  
  TownTest = Town1

End Function
Function TownTest2(ByVal text As String) As String
  Dim result3 As String
  Dim allMatches3 As MatchCollection
  Dim TN2 As regExp
  Dim TrimString As String
  Dim Town1 As String
  Dim LengthOfString As Integer
  
  Set TN2 = CreateObject("VBScript.RegExp")
  TN2.IgnoreCase = True
  TN2.Pattern = "\s[a-z,A-Z]*,"
  'TN.Pattern = "North"
  TN2.Global = True
  
  Set allMatches3 = TN2.Execute(text)

  If allMatches3.Count <> 0 Then
    result3 = allMatches3.Item(0)
    
    MsgBox result3
    TrimString = LTrim(result3)
    'Debug.Print TrimString
    LengthOfString = Len(TrimString)
    'Debug.Print LengthOfString
    Town1 = Left(TrimString, LengthOfString - 1)
    Debug.Print Town1
  Else
    MsgBox "No Matches"
    
    
  End If
  
  TownTest2 = result3

End Function

Sub TestRegex2()

    Dim text As String
    'Dim result As String
    
    'text = "1 Prospect Cir Braintree,MA 02184"
    'Sheet2.Cells(14, 3).Value = CompanyTelephone
    text = Sheet1.Cells(5, 3)
    result = StreetTest(text)
    Street = result
    result2 = TownTest(text)
    Town = result2
    sbGetHomeAddress1
    

End Sub


Sub PrintStringVariable()
Dim RubyCode As String
Dim RubyCode2 As String
'Dim Extension As Range
 

RubyCode = "test0"
RubyCode = RubyCode + Chr(13) + "test1"
Debug.Print RubyCode



For Each cell In Worksheets("Sheet1").Range("I2:I149").Cells

    'Debug.Print cell.Value
    RubyCode2 = RubyCode2 + Chr(13) + cell.Value
        
        
Next cell

Debug.Print RubyCode2


End Sub



Sub RoundToZero2()
    For Each c In Worksheets("Sheet1").Range("A1:D10").Cells
        If Abs(c.Value) < 0.01 Then c.Value = 0
    Next
End Sub


Sub GenericStringArray()
    Dim length As Integer
    Dim gap As Integer
    Dim comma As Integer
    Dim strt(1 To 7) As String
    Dim i As Integer
    Dim start As Integer
    Dim StringArray0 As String
    Dim String0Remainder As String
    Dim StringArray(1 To 7) As String
    'Dim oldGap As String this actually makes no sense as oldGap has no context with HomeAddressRemainder
    Dim ttlLength As Integer
    'Dim zip As String
    'Dim stateZip As String
    'Dim state As String
    'Dim lastComma As Integer
    Dim previousStringArray0Remainder
    Dim commaFromRight As Integer
    Dim startFromRight As Integer
    
    
    
    start = 1
    startFromRight = 1
    'i = 1
    
    
    'MsgBox "StringArray0: " & Sheet1.Cells(5, 3)
    'StringArray0 = Sheet1.Cells(5, 3)
    'StringArray0 = Street
    'StringArray0 = Town
    'StringArray0 = "10 Winter St."
    'StringArray0 = "North Billerica"
    StringArray0 = "Senior Purchasing Analyst North Region"
    
    
    MsgBox "Test Variable StringArray0  " & StringArray0
    Debug.Print "Test Variable StringArray0  " & StringArray0
    ttlLength = Len(StringArray0)
    MsgBox "ttlLength= " & ttlLength
    Debug.Print "ttlLength= " & ttlLength
    StringArray0Remainder = StringArray0
    'zip = Right(HomeAddress, 5)
    'stateZip = Right(HomeAddress, 8)
    'MsgBox "Zip= " & zip
    'MsgBox "stateZip= " & stateZip
    'state = Left(stateZip, 2)
    'MsgBox "state= " & state
    'commaFromRight = InStrRev(StringArray0, ",")
    'Debug.Print HomeAddress
    'MsgBox "commaFromRight= " & commaFromRight
    'Debug.Print "commaFromRight= " & commaFromRight
    
    'strt(1) = "19"
    'strt(2) = "Stuart"
    'strt(3) = "Street"
    'MsgBox strt(i)
    
    'What kind of loop?
    For i = 1 To 7
        MsgBox "Loop"
        start = 1
        'gap = InStr(start, StringArray0, " ")
        gap = InStr(start, StringArray0Remainder, " ")
        MsgBox "gap: " & gap
        Debug.Print "gap: " & gap
        'MsgBox "oldGap=" & oldGap
        comma = InStr(start, StringArray0Remainder, ",")
        'MsgBox "comma: " & comma
        'commaFromRight = InStrRev(HomeAddress, " ", startFromRight)
        'MsgBox "commaFromRight= " & commaFromRight
        
        'MsgBox "lastComma= " & lastComma
        
        
        'If comma = 0 Then
        If gap = 0 Then
            'MsgBox "HomeAddressRemainder= " & HomeAddressRemainder & " Alert 2nd Loop"
            'MsgBox "previousHomeAddressRemainder= " & HomeAddressRemainder
            'MsgBox "strt 1=" & strt(1)
            'MsgBox "strt 2=" & strt(2)
            'MsgBox "strt 3=" & strt(3)
            'MsgBox "strt 4=" & strt(4)
            'MsgBox "strt 5=" & strt(5)
            'MsgBox "strt 6=" & strt(6)
            'MsgBox "strt 7=" & strt(7)
            'MsgBox "state= " & state
            'Debug.Print state
            'MsgBox "zip= " & zip
            'Debug.Print zip
            MsgBox "Looping Out"
            MsgBox "strt " & 1 & " " & strt(1)
            Debug.Print "strt " & 1 & " " & strt(1)
            MsgBox "strt " & 2 & " " & strt(2)
            Debug.Print "strt " & 2 & " " & strt(2)
            MsgBox "strt " & 3 & " " & strt(3)
            Debug.Print "strt " & 3 & " " & strt(3)
            MsgBox "strt " & 4 & " " & strt(4)
            Debug.Print "strt " & 4 & " " & strt(4)
            MsgBox "strt " & 5 & " " & strt(5)
            Debug.Print "strt " & 5 & " " & strt(5)
            MsgBox "strt " & 6 & " " & strt(6)
            Debug.Print "strt " & 6 & " " & strt(6)
            MsgBox "strt " & 7 & " " & strt(7)
            Debug.Print "strt " & 7 & " " & strt(7)
            Debug.Print strt(1) & strt(2) & strt(3) & strt(4) & strt(5) & strt(6) & strt(7) & StringArray0Remainder
            MsgBox "Exiting Sub"
            Exit Sub
        End If
        
        
        
        strt(i) = Left(StringArray0Remainder, gap - 1)
        If Not IsNull(strt(i)) Then
            strt(i) = strt(i) & "\ "
        End If
        
        MsgBox "strt " & i & " " & strt(i)
        Debug.Print "strt " & i & " " & strt(i)
        'StringArray0Remainder = strt(i)
        MsgBox "strt " & i & " " & strt(i)
        Debug.Print "strt " & i & " " & strt(i)
        previousStringArray0 = StringArray0Remainder
        MsgBox "previousStringArray0= " & previousStringArray0
        Debug.Print "previousStringArray0= " & previousStringArray0
        start = gap + 1
        StringArray0Remainder = Mid(StringArray0Remainder, start)
        MsgBox "StringArray0Remainder= " & StringArray0Remainder
        Debug.Print "StringArray0Remainder= " & StringArray0Remainder
        lastComma = comma
        
        'oldGap = gap
    Next i
    
    
    
    
    
    'length = Len(HomeAddress)
    'MsgBox length
End Sub

