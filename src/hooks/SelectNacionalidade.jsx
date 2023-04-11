/* eslint-disable react/prop-types */
import React, { useEffect, useState } from "react";
import { fetchNacionalidade } from "../helpers/ibge";
import { SelectDados } from "../components/AllTabs/StylesAbas-styles";

const SelectNacionalidade = ({ id, name, state, onChange = () => {} }) => {
  const [nacionalidade, setNacionalidade] = useState([]);

  useEffect(() => {
    fetchNacionalidade(state).then((paises) => {
      setNacionalidade(paises);
      console.log.log(fetchNacionalidade);
    });
  }, [state]);
  return (
    <SelectDados
      id={id || name}
      name={name || id}
      onChange={onChange}
      style={{ width: "80%" }}
    >
      <option value="">Selecione uma cidade...</option>
      {nacionalidade.map((paises) => {
        const { id, nome } = paises;
        return (
          <option key={id} value={id}>
            {nome.abreviado}
          </option>
        );
      })}
    </SelectDados>
  );
};

export default SelectNacionalidade;
