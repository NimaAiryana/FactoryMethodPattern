Feature: create new directory

    I should create new directory if not exist

    Scenario: create new directory
        Given directory name
            And directory path
        When order raised to directory service
        Then service should create new directory
            And return created directory physical info
    
    Scenario: if directory exist should not create directory
        Given directory name
            And directory path
        When creating new directory
        Then check new directory name
            And if directory exist don't create new one
            And return current directory physical info