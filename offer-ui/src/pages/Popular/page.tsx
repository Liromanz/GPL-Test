import React from "react"
import { PopularCard, SupplierDto } from "../../components/PopularCard/component"

type popularSuppliers = {
    suppliers: SupplierDto[]
}

const Popular: React.FC<popularSuppliers> = ({suppliers}) => {
    return (
        <div className="container">
            <h1 className="text-center m-3">Популярные поставщики</h1>
            {
                suppliers.map((item) => (
                    <PopularCard name={item.name} offerCount={item.offerCount}/>
                ))
            }
        </div>
    )
}


export default Popular