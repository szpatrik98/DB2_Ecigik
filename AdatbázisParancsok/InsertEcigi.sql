create or replace procedure spInsert_ecigik(
    p_sorszam 	in ecigik.sorszam%type,
    p_nev in ecigik.nev%type,
    p_szin   in ecigik.szin%type,
	p_marka in markak.nev%type,
    p_watt in ecigik.watt%type,
    p_megjelenesev  in ecigik.megjelenesev%type,
    p_tipus in ecigik.tipus%type,
    p_out_rowcnt out int
)
authid definer
as
    v_check_sorszam int;
    v_marka_id int;
begin
    p_out_rowcnt := 0;
    v_marka_id := sf_GetMarkaId(p_marka);
    if v_marka_id is null then
        sp_insertMarkak(p_marka);
        v_marka_id := sf_GetMarkaId(p_marka);
    end if;

    v_check_sorszam := sf_check_sorszam(p_sorszam);
    if v_check_sorszam = 1 then
        insert into ecigik
            (sorszam, nev, szin, marka_id, watt, megjelenesev, tipus)
        values
            (p_sorszam, p_nev, p_szin,  p_marka,p_watt, p_megjelenesev, p_tipus);
        p_out_rowcnt := SQL%rowcount;
        commit;
    end if;
end spInsert_ecigik;