import { Link } from "react-router-dom"

type content = {
    name: string,
    routeTo: string
}

export type headerComponents = {
    comps : content[]
}

export const Header: React.FC<headerComponents> = ({comps}) => {
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