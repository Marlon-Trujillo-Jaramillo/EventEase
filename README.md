# 📅 EventEase - Gestión de Eventos con Blazor

**EventEase** es una aplicación web interactiva desarrollada en **Blazor**. Esta app está diseñada para permitir a los usuarios explorar eventos, ver sus detalles, registrarse y gestionar su participación de manera fluida.

Este proyecto fue construido a lo largo de **tres actividades clave**, con el soporte de **GitHub Copilot** para acelerar el desarrollo, sugerir buenas prácticas y facilitar la depuración.

---

## 🚀 Características principales

- ✅ Tarjetas de evento dinámicas (Event Cards)
- 🔁 Navegación entre páginas con enrutamiento robusto
- 📋 Registro de asistentes con validación de formularios
- 🧠 Gestión de estado para sesiones de usuario
- 📊 Seguimiento de asistencia
- ⚡ Optimización de rendimiento con `Virtualize`
- ❌ Página de error para rutas inválidas

---

## 🛠️ Tecnologías utilizadas

- **Blazor WebAssembly**
- **.NET 9+**
- **C#**
- **GitHub Copilot**
- **HTML / Razor**
- **Bootstrap**

---

## 📚 Estructura del Proyecto

```plaintext
EventEase-app/
├── Pages/
│   ├── Events.razor           # Lista de eventos con Virtualize
│   ├── EventDetails.razor     # Página de detalles del evento
│   ├── EventRegister.razor         # Formulario de registro con validación
│   └── NotFound.razor         # Página para rutas no existentes
├── Shared/
│   └── EventCard.razor        # Componente reutilizable de tarjeta de evento
├── Models/
│   └── EventModel.cs          # Modelo de datos para eventos
│   └── RegistrationModel.cs   # Modelo para el registro de usuarios
└── App.razor                  # Configuración de rutas
```

---

## 🔍 Actividades desarrolladas

### 🧩 Actividad 1: Componentes y Enrutamiento

- Se creó el componente `EventCard` para representar eventos.
- Se configuró el enrutamiento con `@page` y `<Router>`.
- Se usó `Virtualize` para cargar eficientemente listas grandes de eventos (1000+).

### 🐞 Actividad 2: Depuración y Optimización

- Se agregó validación a los modelos (`[Required]`, `[EmailAddress]`, etc.).
- Se implementó una página personalizada para rutas inválidas (`/notfound`).
- Se mejoró el rendimiento de carga con virtualización.

### ⚙️ Actividad 3: Características avanzadas

- Se construyó un formulario de registro con `EditForm` y `DataAnnotationsValidator`.
- Se añadió lógica para gestionar estado de sesión del usuario.
- Se implementó lógica para mostrar mensajes de confirmación de asistencia.

---

## 🧪 Cómo probar la aplicación

1. Clona el repositorio:
   ```bash
   git clone [https://github.com/tu-usuario/EventEase-app.git](https://github.com/Marlon-Trujillo-Jaramillo/EventEase.git)
   ```
2. Abre la solución en **Visual Studio 2022+**
3. Asegúrate de que el SDK .NET 6 o superior esté instalado.
4. Ejecuta el proyecto (`F5` o botón de Play)

---

## 📬 Contacto

Desarrollado por Marlon Trujillo. Si tienes preguntas, puedes escribirme vía GitHub.

---

¡Gracias por revisar **EventEase**! 🎉
