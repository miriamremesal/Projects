import './Navbar.css'

function Navbar() {

    let itemsNav = ['Contact', 'Services', 'Info', 'About us'];

    return (
        <nav>
            {/* <ul>
                <li>Contacto</li>
                <li>Servicios</li>
                <li>Info</li>
                <li>Home</li>
                <li>Search</li>
            </ul> */}

            {itemsNav.map(element => {
                return <li>{element}</li> 
            })}

            <h1 className='title'>Helloooo</h1>
            <img src="" alt="" /> 
        </nav>
    )
}

export default Navbar;