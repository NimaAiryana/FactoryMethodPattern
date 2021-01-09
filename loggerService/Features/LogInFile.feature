Feature: log in file

    should log data in .log file by date filename
    Example: 2021-01-08.log
    if file don't exist , file should create first

    Scenario: write log data in date.log file
        Given log data
            And server date for filename
            Example: 2021-01-08.log
            And filepath
        When logger order to log data in file
        Then filelogger should check log file in filepath
            And if don't exist should create file
            And write log data in log file