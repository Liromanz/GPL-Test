import { Children } from "react";
import { Header, headerComponents } from "../components/Header/component";
import { Outlet } from "react-router-dom";

const headerComps: headerComponents = {
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
