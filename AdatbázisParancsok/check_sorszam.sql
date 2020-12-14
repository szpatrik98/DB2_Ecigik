create or replace function sf_check_sorszam
(
    p_sorszam in ecigik.sorszam%type
)
return int
deterministic
as
    v_sorszam_char char(1);
    v_i int;
begin
    if p_sorszam is null then
        return 0;
    end if;

    if length(trim(p_sorszam)) = 6 then
        v_i := 1;
       
        while v_i <= 6 loop
            v_sorszam_char := substr(v_sorszam_char, v_i, 1);
            if not (ascii('0') <= ascii(v_sorszam_char) and ascii(v_sorszam_char) <= ascii('9') and (ascii('A') <= ascii(v_rendszam_char) and ascii(v_rendszam_char) <= ascii('Z'))) then
                return 0;            
            end if;
            v_i := v_i + 1;
        end loop;
        return 1;
    end if;
    return 0;
end sf_check_sorszam;