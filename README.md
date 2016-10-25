# CWUtilsLibrary
Library of code i use


# DesignPatterns
Mina DesignPatterns i C#

## Creational Patterns

Abstract Factory
> Pattern - The Purpose of Abstract Factory is to provide an interface for creating families of related objects, without specifying concrete classes. Whereas 'Factory Method' pattern abstracts the user from the creation of an object, the 'Abstract Factory' method abstracts the user from the creation of the factory itself.
>> My Example - In an order-environmen where the structure of data the orders use are different. I call the structures V1 and V5 

<code>
data - object holding all raw data from datasource

Order - An order containing orderData
Order_V1 : Order - An order reading data from v1 data-structure
Order_V5 : Order - An order reading data from v5 data-structure

VB - An EDI representing Varubrev
VB_1 : VB - An EDI representing Varubrev reading from v1 data-structure
VB_5 : VB - An EDI representing Varubrev reading from v5 data-structure

FaktoryMaker
  GetFactory(data) : AbstractFactory
AbstractFactory 
  CreatOrder(data) - Creates and returns an order
  CreateVB_EDI(data) - Creates and returns an VB_EDI object
V1_Factory : Abstractfactory 
  CreateOrder
  CreateVB_EDI
V5_Factory : AbstractFactory
  CreateOrder
  CreateVB_EDI
Order
  V1_Order : Order
  V5_Order : Order
VB_EDI
  V1_VB_EDI : VB
  V5_VB_EDI : VB
  
AbstractFactory aFactory = FactoryMaker.GetFactory(data);
Order o = aFactory.CreateOrder(data);
VB vp = aFactory.CreateVB_EDI(data);
</code>

Builder - 

Factory Method -

Prototype - 

Singleton - 



## Structural Patterns

Adapter - 

Bridge - 

Composite - 

Decorator - 

Facade - 

Flyweight
> Pattern - The Flyweight pattern applies to a program using a huge number of objects that have part of their internal state in common where the other part of state can vary. The pattern is used when the larger part of the object can be made extrinsic (external to that object). uses a Factory that can cache and reuse existing class instances.

>> My Example - Could be used in SendEmail Class when using XslCompiledTransform to transform the email since 
when you use embedded script(<msxsl:script>) with an XSL file, an assembly that contains Microsoft Intermediate Language (MSIL) is created and loaded into memory. Because of a design limitation in this version of the Microsoft .NET Framework, you cannot unload that assembly from memory. There fore, develop your application in such a way that you load the XSLT once and reuse it as many times as needed. I.E. Flyweight all different emails using XslCompiledTransform with different xsl-files so they are used only once.

Proxy - 



## Behavioral Patterns

Chain of Responsibility - 

Command - 

Interpreter - 

Iterator - 

Mediator - 

Memento - 

Observer - 

State - 

Strategy - 

Template - 

Visitor - 



==============================================






*Flyweight* - 
*Prototype* - Reuse of objects alread created that share alot of the same info
*Facade* - A facade to complex code sequence. I.E. like makeOrder()
*Proxy* - The Proxy pattern is used when you need to represent an object that is complex or time consuming to create with a simpler one. I.E. ImageLoading
*ChainOfResponsibility* - Launch-and-leave requests with a single processing pipeline that contains many possible handlers- ATM Desposit $notes
*Command* - Send actions to a reciever by sending A Command object - I.E. Send Close, Print, Collect command to OrderEdit.
*Iterator* - Create a Class that iterats over items in a collection-class. I.E. Iterat over users
*Mediator* - One class is used to communicte between classes like a request/response system
.IE like Users in message chat or GUI updates.
*Observer* - Define a one-to-many dependency between objects so that when one object changes state, all its depedents are notified and updated automatically. E.I. like
UI updates from my FileServer.

=======================
Decorator - ***** Decorate Beverage
Adaptor - ********
Composite - ****** Tree










