Feature: TimeMaterialsFeature

As a TurnUp portal User
I want to create ,Edit and Delete an Employee details
So that I can manage the TimeMaterials Records Successfully

@tag1
Scenario: Create the Time Materials with Valid details
	Given I logged in to Turn Up Portal successfully
	And I navigate to Time and Materials Page
	When I create a new time records
	Then the new record should be created successfully

Scenario Outline: Editing the Time Materials with Valid Details
Given I logged in to Turn Up Portal successfully
And  I navigate to Time and Materials Page
When I  update '<Code>' '<Description>'on existing Time Records
Then the record should have updated '<Code>' '<Description>'

Examples: 
| Code     | Description |
| Ball     | Basket      |
| 12345    | Numbers     |
| Paper45@ | Write       |

Scenario: Delete the Time Materials Record
Given I logged in to Turn Up Portal successfully
And I navigate to Time and Materials Page
When I delete a New Time Material Record
Then  the existing record should be deleted successfully	