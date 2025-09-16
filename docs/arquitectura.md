### Arquitectura y Dominio de OgameAnalytics

Este documento describe cómo está construida la solución, el flujo entre capas y, en especial, el modelo de Dominio: entidades, value objects, servicios y reglas.

## Proyectos y capas

- **`src/OgameAnalytics.Domain`**: Núcleo del dominio (Entidades, Value Objects, Enums, Servicios de dominio, Datos de costes/factores, Excepciones).
- **`src/OgameAnalytics.Application`**: Casos de uso (interfaces, requests/responses, handlers). Orquesta el dominio. Algunos handlers están en progreso.
- **`src/OgameAnalytics.Infrastructure`**: Infraestructura (EF Core `OgameDbContext`, DI).
- **`src/OgameAnalytics.API`**: API ASP.NET Core. Registra DI e expone controladores de casos de uso.
- **`src/OgameAnalytics.Frontend`**: Blazor Server. Cliente que consume la API.

## Flujo alto nivel

1. Frontend llama a la API (p.ej. calcular coste de mejora).
2. API delega en un caso de uso de `Application` (handler via interfaz).
3. El handler usa Servicios del Dominio y Entidades/VO para calcular.
4. La respuesta de `Application` se mapea a DTO y se devuelve al Frontend.

## Dominio

### Agregado principal: `Planet`

- Mantiene identidad, nombre, coordenadas, temperatura y forma de vida.
- Contiene el conjunto de edificios como diccionario por `BuildingIdentity`.
- Se instancia “vacío” y se autocompleta con edificios según la forma de vida.

```12:33:src/OgameAnalytics.Domain/Planets/Planet.cs
public PlanetId Id { get; private set; }
public PlanetName Name { get; private set; }
public PlanetCoordinate Coordinates { get; private set; }
public PlanetTemperature Temperature { get; private set; }
public PlanetLifeForm LifeForm { get; private set; }
private readonly Dictionary<BuildingIdentity, Building> _buildingsByIdentity;
public IReadOnlyCollection<Building> Buildings => _buildingsByIdentity.Values;
public Building GetBuilding(ResourceBuilding type) => _buildingsByIdentity[BuildingIdentity.FromBuildingType(type)];
```

```72:103:src/OgameAnalytics.Domain/Planets/Planet.cs
public static Planet CreateEmpty(PlanetId id, PlanetName name, PlanetCoordinate coordinates, PlanetTemperature temperature, PlanetLifeForm lifeForm)
{
    Dictionary<BuildingIdentity, Building> buildingsByIdentity = GenerateBuildingsDictionaryForSelectedLifeForm(lifeForm);
    return new Planet(id, name, coordinates, temperature, lifeForm, buildingsByIdentity);
}