export type SupplierDto = {
  name: string;
  offerCount: number;
}

export const PopularCard: React.FC<SupplierDto> = ({name, offerCount}) => {
    return (
        <div className="card">
            <div className="card-body">
                <h5 className="card-title">{name}</h5>
                <p className="card-text">Количество офферов: {offerCount}</p>
            </div>
        </div>
    )
}