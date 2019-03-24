# Experiment task

The main goal is to implement the same server with the same API entries and with the same response using different languages/platforms and compare them via metrics.

## Basic requirements

The server should be run by executing the file in **single-thread mode / only one instance** itself.

```bash
$ ./run.sh
```

## API entries

Please implement the next API entries:

| Method | Path        | Description                                                                                                                                                             |
| ------ | ----------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| GET    | /empty      | Response nothing (just empty response)                                                                                                                                  |
| GET    | /users.html | Render static HTML page without template engine (please use `./templates/users.html` file for this purpose)                                                             |
| GET    | /mock-users | Render HTML with template engine but with mock users (users should be placed as an array inside server's code, do not read it from json file or other similar approach) |
| GET    | /db-users   | Render HTML with template engine and get users from MySQL                                                                                                               |

## HTML Template

Please follow the template in `./tempates/users.html` and use it for all responses (make changes to be able to render it with your template engine)

## User list

The list if available as an SQL dump (`./data/users.sql`) and json file (`./data/users.json`).
If it is possible, please use ORM integrated with your framework by default.
Please follow the next tables schema:

![GitHub Logo](/data/users-scheme.png)

## Pull requests

Please commit to this repo in to `./platforms/*` folder following the next template: `./platforms/{language/platform}_{framework}_{version}_{your_name}`.
Example: `./platforms/nodejs_nestjs_6.0.1_IhorLev`.

Have fun! :)
