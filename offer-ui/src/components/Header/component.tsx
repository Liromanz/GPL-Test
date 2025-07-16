import { Link } from "react-router-dom"
import { useHeaderComponents } from "./types"

export const Header: React.FC<useHeaderComponents> = ({comps}) => {
    return (
        <header className="d-flex justify-content-center py-3 bg-dark">
            <ul className="nav nav-pills">
                {
                    comps.map((item) => (
                        <li className="nav-item">
                            <Link to={item.routeTo} className="nav-link text-white" >{item.name}</Link>
                        </li>
                    ))
                }
            </ul>
        </header>
    )
}