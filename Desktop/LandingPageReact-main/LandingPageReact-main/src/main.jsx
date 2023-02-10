import React from 'react'
import ReactDOM from 'react-dom/client'
import Navbar from './components/Navbar'
import './main.css'

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <Navbar />
    {/* <Navbar items={["Contact", "Services", "Info"]} /> */}
  </React.StrictMode>,
)

// crear componentes jsx y css (en carpeta components en src), y luego aqui en main en linea 8 detras de App: logo navbar home lo que sea x orden
// en assets van las imagenes, logo..
// node_modules y package-lock.json con el npm i (son necesarios)
// para rutas secundarias (para que nuestra pagina te lleve a otras paginas) crear carpeta pages en src y dentro de pages Home.jsx x ej (Router) 
// si quisieramos los items del nav en main en vez de en el component navbar, borrar en navbar la variable itemsNav (FALTA+)