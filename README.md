1. Start up PostgreSQL container with:
```
docker-compose up -d
```

2. Run ASP.NET Core Project.

3. Execute the following GraphQL mutation:
```graphql
mutation {
  createDemoEvents {
    id
    name
    summary
    description
    participants {
      id
      name
    }
  }
}
```

4. Go through the following scenarios:

    A. Execute the following GraphQL query:
    ```graphql
    query {
      webStyleSearchCorrect {
        id
        name
        summary
        description
        participants {
          id
          name
        }
      }
    }
    ```
    Executing the above query yields three results. This is correct.

    B. Execute the following GraphQL query:
    ```graphql
    query {
      participantFilterCorrect {
        id
        name
        summary
        description
        participants {
          id
          name
        }
      }
    }
    ```
    Executing the above query yields one result. This is correct.

    C. Execute the following GraphQL query:
    ```graphql
    query {
      summaryOrParticipantCorrect {
        id
        name
        summary
        description
        participants {
          id
          name
        }
      }
    }
    ```
    Executing the above query yields two results. This is correct.

    D. Execute the following GraphQL query:
    ```graphql
    query {
      summaryAndParticipantIncorrect {
        id
        name
        summary
        description
        participants {
          id
          name
        }
      }
    }
    ```
    Executing the above query yields three results. This is incorrect. The correct result should be one.

    E. Execute the following GraphQL query:
    ```graphql
    query {
      webStyleSearchAndParticipantIncorrect {
        id
        name
        summary
        description
        participants {
          id
          name
        }
      }
    }
    ```
    Executing the above query yields two results. This is incorrect. The correct result should be one.