import { Header } from "../components/Header/component";
import { Outlet } from "react-router-dom";
import { useHeaderComponents } from "../components/Header/types";

const headerComps: useHeaderComponents = {
    comps: [
        {
            name: "Популярные поставщики",
            routeTo: "/popular"
        },
        {
            name: "Поиск по офферам",
            routeTo: "/"
        },
    ]
}

export const MainLayout = () => {
    return (
        <div>
            <Header comps={headerComps.comps} />
            <main>
                <Outlet />
            </main>
        </div>
    )
}
