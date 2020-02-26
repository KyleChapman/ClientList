Option Strict On

''' <summary>
''' Original Author:    Alfred Massardo
''' Original Date:      05-Jan-2018
''' Last Modified By:   Kyle Chapman
''' Last Modified Date: Feb 26, 2020
''' Project Name:       CustomerList
''' Description:
'''     A class designed to as a record of an individual customer, including a little information that describes their importance.
''' </summary>
Public Class Customer

    Private Shared customerCount As Integer                 ' static or shared private variable to hold the number of customers
    Private customerIdentificationNumber As Integer = 0     ' private variable to hold the customer's identification number
    Private customerTitle As String = String.Empty         ' private variable to hold the customer's title
    Private customerFirstName As String = String.Empty     ' private variable to hold the customer's first name
    Private customerLastName As String = String.Empty      ' private variable to hold the customer's last name
    Private customerVeryImportantPersonStatus As Boolean = False              ' private variable to hold the customer's status

    ''' <summary>
    ''' Constructor - Default - creates a new customer object
    ''' </summary>
    Public Sub New()

        customerCount += 1      ' increment the shared/static variable counter by 1
        customerIdentificationNumber = customerCount ' assign the customers id

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new customer object
    ''' </summary>
    ''' <param name="title"></param>
    ''' <param name="firstName"></param>
    ''' <param name="lastName"></param>
    ''' <param name="veryImportantPersonStatus"></param>
    Public Sub New(title As String, firstName As String, lastName As String, veryImportantPersonStatus As Boolean)

        ' call the other constructor 
        ' to set the customer count and
        ' to set the customer id
        Me.New()

        customerTitle = title          ' set the customer title
        customerFirstName = firstName  ' set the customer first name
        customerLastName = lastName    ' set the customer last name
        customerVeryImportantPersonStatus = veryImportantPersonStatus        ' set the customer status

    End Sub

    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of customers that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return customerCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific customers identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return customerIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' VeryImportantPersonStatus Property - >Gets and Sets the Very Important Person status of a customer
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property VeryImportantPersonStatus() As Boolean
        Get
            Return customerVeryImportantPersonStatus
        End Get
        Set(ByVal value As Boolean)
            customerVeryImportantPersonStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Title property - Gets and Sets the title of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Title() As String
        Get
            Return customerTitle
        End Get
        Set(ByVal value As String)
            customerTitle = value
        End Set
    End Property

    ''' <summary>
    ''' FirstName property - Gets and Sets the first name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property FirstName() As String
        Get
            Return customerFirstName
        End Get
        Set(ByVal value As String)
            customerFirstName = value
        End Set
    End Property

    ''' <summary>
    ''' LastName property - Gets and Sets the last name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property LastName() As String
        Get
            Return customerLastName
        End Get
        Set(ByVal value As String)
            customerLastName = value
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "Hi my name is " & customerTitle & " " & customerFirstName & " " & customerLastName & ", " & IIf(customerVeryImportantPersonStatus = True, "I am a VIP", "I am not a VIP").ToString()

    End Function

End Class
