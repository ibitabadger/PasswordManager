Feature: Hashing

  Comprobar que la tabla hash está indexando correctamente las cuentas.

  @hashing
  Scenario: Indexar una cuenta correctamente
    Given una tabla hash vacía
    And una cuenta para el sitio web "facebook" y nombre de usuario "Juan Perez" y contraseña "22391"
    When se inserta la cuenta en la tabla hash
    Then la cuenta debe estar indexada en la tabla hash con la clave "facebook"

  @hashing
  Scenario: Manejo de colisiones
    Given una tabla hash con una cuenta con id "67890" y nombre "Ana Lopez" indexada en la posición X
    And una cuenta con id "67891" y nombre "Pedro Martinez" que produce una colisión con la posición X
    When se inserta la cuenta con id "67891" en la tabla hash
    Then la cuenta con id "67891" debe ser gestionada correctamente en la tabla hash

  @hashing
  Scenario: Recuperar una cuenta por su id
    Given una tabla hash con una cuenta con id "54321" y nombre "Maria Garcia"
    When se busca la cuenta con id "54321" en la tabla hash
    Then la cuenta con id "54321" debe ser recuperada con el nombre "Maria Garcia"

  @hashing
  Scenario: Eliminar una cuenta
    Given una tabla hash con una cuenta con id "11223" y nombre "Carlos Diaz"
    When se elimina la cuenta con id "11223" de la tabla hash
    Then la cuenta con id "11223" ya no debe existir en la tabla hash

  @hashing
  Scenario: Actualizar una cuenta
    Given una tabla hash con una cuenta con id "33445" y nombre "Luisa Fernandez"
    When se actualiza el nombre de la cuenta con id "33445" a "Luisa Gonzalez"
    Then la cuenta con id "33445" debe tener el nombre actualizado a "Luisa Gonzalez" en la tabla hash