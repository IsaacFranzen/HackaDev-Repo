/* eslint-disable react/prop-types */
import React from "react";
import { useEffect } from "react";
import { fetchCidades } from "../helpers/ibge";
import { useState } from "react";
import { SelectDados } from "../components/AllTabs/StylesAbas-styles";

const SelectCidades = ({ id, name, state, onChange = () => {} }) => {
  const [cidades, setCidades] = useState([]);

  useEffect(() => {
    fetchCidades(state).then((cidades) => {
      setCidades(cidades);
    });
  }, [state]);
  return (
    <SelectDados id={id || name} name={name || id} onChange={onChange}>
      <option value="">Selecione uma cidade...</option>
      {cidades.map((cidade) => {
        const { id, nome } = cidade;
        return (
          <option key={id} value={id}>
            {nome}
          </option>
        );
      })}
    </SelectDados>
  );
};

export default SelectCidades;
