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
When I  update '<Code>'on existing Time Records
Then the record should have updated '<Code>'

Examples: 
| Code     |
| Ball     |
| 12345    |
| Paper45@ |

