Feature: Hashing

  Comprobar que la tabla hash está indexando correctamente las cuentas en la clase HashTable1.

  @hashing
  Scenario: Indexar una cuenta correctamente
    Given una tabla hash de tamaño 10
    And un usuario con email "test@example.com", nombre de usuario "testuser" y contraseña "testpass"
    And una cuenta con sitio web "example.com", nombre de usuario "juanperez" y contraseña "password123"
    When se inserta la cuenta con sitio web "example.com" en la tabla hash
    Then la cuenta con sitio web "example.com" debe estar indexada en la tabla hash

  @hashing
  Scenario: Manejo de colisiones
    Given una tabla hash de tamaño 10
    And un usuario con email "test@example.com", nombre de usuario "testuser" y contraseña "testpass"
    And una cuenta con sitio web "site1.com", nombre de usuario "analopez" y contraseña "password456" indexada
    And una cuenta con sitio web "site2.com", nombre de usuario "pedromartinez" y contraseña "password789" que produce una colisión
    When se inserta la cuenta con sitio web "site2.com" en la tabla hash
    Then la cuenta con sitio web "site2.com" debe ser gestionada correctamente en la tabla hash

  @hashing
  Scenario: Recuperar una cuenta por su sitio web
    Given una tabla hash de tamaño 10
    And un usuario con email "test@example.com", nombre de usuario "testuser" y contraseña "testpass"
    And una cuenta con sitio web "mywebsite.com", nombre de usuario "mariagarcia" y contraseña "mypassword" indexada
    When se busca la cuenta con sitio web "mywebsite.com" en la tabla hash
    Then la cuenta con sitio web "mywebsite.com" debe ser recuperada con nombre de usuario "mariagarcia" y contraseña "mypassword"

  @hashing
  Scenario: Eliminar una cuenta
    Given una tabla hash de tamaño 10
    And un usuario con email "test@example.com", nombre de usuario "testuser" y contraseña "testpass"
    And una cuenta con sitio web "example.org", nombre de usuario "carlosdiaz" y contraseña "pass123" indexada
    When se elimina la cuenta con sitio web "example.org" de la tabla hash
    Then la cuenta con sitio web "example.org" ya no debe existir en la tabla hash

  @hashing
  Scenario: Actualizar una cuenta
    Given una tabla hash de tamaño 10
    And un usuario con email "test@example.com", nombre de usuario "testuser" y contraseña "testpass"
    And una cuenta con sitio web "example.com", nombre de usuario "juanperez" y contraseña "password123" indexada

