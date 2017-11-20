Feature: SpecFlowFeature1
	In order to develop RPN calc
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers
	Given I have entered <Num1> into the calculator
	And I have entered <Num2> into the calculator
	And I have entered <op> into the calculator
	When I press Enter
	Then the result should be <Num2> <op> <Num1> on the screen

	Examples: 
	| Num1 | Num2 |op|
	| 5    | 2  | +    |

