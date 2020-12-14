create or replace function sf_check_nev
(
    p_nev in ecigik.nev%type
)
return int
deterministic
as
    v_nev_char char(1);
    v_i int;
begin
    if p_nev is null then
        return 0;
    end if;

    if length(trim(p_nev)) = 15 then
        v_i := 1;
       
        while v_i <= 15 loop
            v_nev_char := substr(v_nev_char, v_i, 1);
            if not (ascii('A') <= ascii(v_rendszam_char) and ascii(v_rendszam_char) <= ascii('Z')) then
                return 0;            
            end if;
            v_i := v_i + 1;
        end loop;
        return 1;
    end if;
    return 0;
end sf_check_nev;